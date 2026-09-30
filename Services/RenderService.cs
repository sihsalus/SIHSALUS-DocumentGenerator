using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using Microsoft.Playwright;
using System.Text.RegularExpressions;

namespace SIHSALUS_DocumentGenerator.Services;

/// <summary>
/// Converts safe, self-contained HTML documents into PDF files.
/// </summary>
public interface IRenderService
{
    /// <summary>
    /// Sanitizes <paramref name="html"/> and renders it as a PDF, honoring CSS-defined page sizes.
    /// The returned bytes can be returned directly from an ASP.NET controller as
    /// <c>application/pdf</c>.
    /// </summary>
    Task<byte[]> RenderHtmlToPdfAsync(string html, CancellationToken cancellationToken = default);
}

/// <summary>
/// Uses Playwright Chromium to convert sanitized HTML to PDF.
/// </summary>
public sealed class RenderService : IRenderService
{
    private const int MaxHtmlLength = 2 * 1024 * 1024;
    private const float RenderTimeoutMilliseconds = 30_000;

    private static readonly HashSet<string> AllowedTags = new(StringComparer.OrdinalIgnoreCase)
    {
        "html", "head", "body", "title", "style",
        "main", "section", "article", "header", "footer", "aside", "div", "span",
        "p", "br", "hr", "h1", "h2", "h3", "h4", "h5", "h6",
        "strong", "b", "em", "i", "u", "s", "small", "sub", "sup", "mark",
        "blockquote", "pre", "code", "figure", "figcaption",
        "ul", "ol", "li", "dl", "dt", "dd",
        "table", "caption", "thead", "tbody", "tfoot", "tr", "th", "td", "colgroup", "col",
        "img", "label", "input", "textarea", "select", "option"
    };

    private static readonly HashSet<string> ForbiddenTags = new(StringComparer.OrdinalIgnoreCase)
    {
        "script", "noscript", "iframe", "frame", "frameset", "object", "embed", "applet",
        "base", "link", "meta", "svg", "math", "template", "canvas", "video", "audio", "source"
    };

    private static readonly HashSet<string> AllowedAttributes = new(StringComparer.OrdinalIgnoreCase)
    {
        "id", "class", "style", "title", "lang", "dir", "role", "alt", "width", "height",
        "colspan", "rowspan", "span", "start", "type", "value", "checked", "selected", "disabled",
        "readonly", "placeholder", "scope"
    };

    // URLs in CSS are not needed for generated documents, and removing them keeps rendering offline.
    private static readonly Regex UnsafeCss = new(
        @"(?is)@import\s+(?:url\s*\([^)]*\)|[^;]*);|url\s*\([^)]*\)|expression\s*\([^)]*\)|(?:javascript|vbscript)\s*:|-moz-binding\s*:|behavior\s*:",
        RegexOptions.Compiled | RegexOptions.CultureInvariant);

    private static readonly Regex SafeImageDataUrl = new(
        @"\Adata:image/(?:png|jpeg|gif|webp);base64,[a-z0-9+/=\s]+\z",
        RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

    /// <inheritdoc />
    public async Task<byte[]> RenderHtmlToPdfAsync(string html, CancellationToken cancellationToken = default)
    {
        string sanitizedHtml = SanitizeHtml(html);

        using IPlaywright playwright = await Playwright.CreateAsync();
        await using IBrowser browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = true
        });
        await using IBrowserContext context = await browser.NewContextAsync(new BrowserNewContextOptions
        {
            JavaScriptEnabled = false,
            ViewportSize = new ViewportSize { Width = 1240, Height = 1754 }
        });

        IPage page = await context.NewPageAsync();
        page.SetDefaultTimeout(RenderTimeoutMilliseconds);
        await page.RouteAsync("**/*", route => route.AbortAsync());

        await page.SetContentAsync(sanitizedHtml, new PageSetContentOptions
        {
            WaitUntil = WaitUntilState.Load,
            Timeout = RenderTimeoutMilliseconds
        });
        await page.EmulateMediaAsync(new PageEmulateMediaOptions { Media = Media.Print });

        return await page.PdfAsync(new PagePdfOptions
        {
            Format = "A4",
            PrintBackground = true,
            PreferCSSPageSize = true,
            Margin = new Margin { Top = "0", Right = "0", Bottom = "0", Left = "0" }
        });
    }

    /// <summary>
    /// Removes executable and remote-resource-capable markup while preserving printable structure and CSS.
    /// </summary>
    public static string SanitizeHtml(string html)
    {
        if (string.IsNullOrWhiteSpace(html))
        {
            throw new ArgumentException("HTML content is required.", nameof(html));
        }

        if (html.Length > MaxHtmlLength)
        {
            throw new ArgumentException($"HTML content cannot exceed {MaxHtmlLength} characters.", nameof(html));
        }

        HtmlParser parser = new();
        IHtmlDocument document = parser.ParseDocument(html);

        foreach (IElement element in document.All.ToArray())
        {
            string tagName = element.LocalName;
            if (ForbiddenTags.Contains(tagName))
            {
                element.Remove();
                continue;
            }

            if (!AllowedTags.Contains(tagName))
            {
                Unwrap(element);
                continue;
            }

            SanitizeAttributes(element);
            if (string.Equals(tagName, "style", StringComparison.OrdinalIgnoreCase))
            {
                element.TextContent = UnsafeCss.Replace(element.TextContent, string.Empty);
            }
        }

        VerifySafeDocument(document);
        return $"<!DOCTYPE html>{document.DocumentElement!.OuterHtml}";
    }

    private static void Unwrap(IElement element)
    {
        INode? parent = element.Parent;
        if (parent is null)
        {
            element.Remove();
            return;
        }

        foreach (INode child in element.ChildNodes.ToArray())
        {
            parent.InsertBefore(child, element);
        }

        element.Remove();
    }

    private static void SanitizeAttributes(IElement element)
    {
        foreach (IAttr attribute in element.Attributes.ToArray())
        {
            string attributeName = attribute.Name;
            if (attributeName.StartsWith("on", StringComparison.OrdinalIgnoreCase) ||
                attributeName is "href" or "srcdoc" or "action" or "formaction")
            {
                element.RemoveAttribute(attributeName);
                continue;
            }

            if (string.Equals(attributeName, "src", StringComparison.OrdinalIgnoreCase))
            {
                if (!string.Equals(element.LocalName, "img", StringComparison.OrdinalIgnoreCase) ||
                    !SafeImageDataUrl.IsMatch(attribute.Value))
                {
                    element.RemoveAttribute(attributeName);
                }

                continue;
            }

            if (string.Equals(attributeName, "style", StringComparison.OrdinalIgnoreCase))
            {
                element.SetAttribute(attributeName, UnsafeCss.Replace(attribute.Value, string.Empty));
                continue;
            }

            if (!AllowedAttributes.Contains(attributeName) &&
                !attributeName.StartsWith("aria-", StringComparison.OrdinalIgnoreCase) &&
                !attributeName.StartsWith("data-", StringComparison.OrdinalIgnoreCase))
            {
                element.RemoveAttribute(attributeName);
            }
        }
    }

    private static void VerifySafeDocument(IHtmlDocument document)
    {
        foreach (IElement element in document.All)
        {
            if (ForbiddenTags.Contains(element.LocalName) || !AllowedTags.Contains(element.LocalName))
            {
                throw new InvalidOperationException("The HTML contains an unsupported element after sanitization.");
            }

            foreach (IAttr attribute in element.Attributes)
            {
                if (attribute.Name.StartsWith("on", StringComparison.OrdinalIgnoreCase) ||
                    attribute.Name is "href" or "srcdoc" or "action" or "formaction" ||
                    (string.Equals(attribute.Name, "src", StringComparison.OrdinalIgnoreCase) &&
                     !SafeImageDataUrl.IsMatch(attribute.Value)) ||
                    (string.Equals(attribute.Name, "style", StringComparison.OrdinalIgnoreCase) &&
                     UnsafeCss.IsMatch(attribute.Value)))
                {
                    throw new InvalidOperationException("Unsafe HTML remained after sanitization.");
                }
            }

            if (string.Equals(element.LocalName, "style", StringComparison.OrdinalIgnoreCase) &&
                UnsafeCss.IsMatch(element.TextContent))
            {
                throw new InvalidOperationException("Unsafe CSS remained after sanitization.");
            }
        }
    }
}
