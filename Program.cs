using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using SIHSALUS_DocumentGenerator.Data;
using SIHSALUS_DocumentGenerator.Services;

// .env is a local-development convenience. Container and host environment
// variables are loaded by the runtime and always take precedence.
LoadDotEnv(Path.Combine(Directory.GetCurrentDirectory(), ".env"));
SetAspNetCoreEnvironmentFromAppMode();

var builder = WebApplication.CreateBuilder(args);

var appPort = GetPortEnvironmentVariableOrDefault("APP_PORT", GetFirstHttpPortFromAspNetCoreHttpPorts() ?? "3000");
var appMode = GetEnvironmentVariableOrDefault("APP_MODE", "PROD");
var encryptionKey = GetRequiredEnvironmentVariable("ENCRYPTION_KEY");
var securityToken = GetRequiredEnvironmentVariable("SECURITY_TOKEN");

var dbHost = GetRequiredEnvironmentVariable("DB_HOST");
var dbPort = GetRequiredPortEnvironmentVariable("DB_PORT");
var dbName = GetRequiredEnvironmentVariable("DB_NAME");
var dbUser = GetRequiredEnvironmentVariable("DB_USER");
var dbPassword = GetRequiredEnvironmentVariable("DB_PASSWORD");

var connectionString = new NpgsqlConnectionStringBuilder
{
    Host = dbHost,
    Port = dbPort,
    Database = dbName,
    Username = dbUser,
    Password = dbPassword
}.ConnectionString;

builder.WebHost.UseUrls($"http://*:{appPort}");

builder.Configuration["App:Mode"] = appMode;
builder.Configuration["App:EncryptionKey"] = encryptionKey;
builder.Configuration["App:SecurityToken"] = securityToken;

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddSingleton<IRenderService, RenderService>();
builder.Services.AddControllers();
builder.Services.AddOpenApi();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.Use(async (context, next) =>
{
    if (HttpMethods.IsOptions(context.Request.Method))
    {
        await next();
        return;
    }

    var endpoint = context.GetEndpoint();
    var allowAnonymous = endpoint?.Metadata.GetMetadata<IAllowAnonymous>() is not null;

    if (allowAnonymous)
    {
        await next();
        return;
    }

    if (!context.Request.Headers.TryGetValue("fuagentoken", out var providedToken) ||
        !string.Equals(providedToken, securityToken, StringComparison.Ordinal))
    {
        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        await context.Response.WriteAsync("Invalid or missing API token.");
        return;
    }

    await next();
});

app.UseAuthorization();
app.MapControllers();
app.Run();

static string GetRequiredEnvironmentVariable(string key)
{
    var value = Environment.GetEnvironmentVariable(key);
    if (string.IsNullOrWhiteSpace(value))
    {
        throw new InvalidOperationException($"Missing required environment variable: {key}");
    }

    return value;
}

static string GetEnvironmentVariableOrDefault(string key, string defaultValue)
{
    var value = Environment.GetEnvironmentVariable(key);
    return string.IsNullOrWhiteSpace(value) ? defaultValue : value;
}

static int GetRequiredPortEnvironmentVariable(string key)
{
    return ParsePort(key, GetRequiredEnvironmentVariable(key));
}

static int GetPortEnvironmentVariableOrDefault(string key, string defaultValue)
{
    return ParsePort(key, GetEnvironmentVariableOrDefault(key, defaultValue));
}

static int ParsePort(string key, string value)
{
    if (!int.TryParse(value, out var port) || port is < 1 or > 65535)
    {
        throw new InvalidOperationException($"Environment variable {key} must be a port between 1 and 65535.");
    }

    return port;
}

static string? GetFirstHttpPortFromAspNetCoreHttpPorts()
{
    var configuredPorts = Environment.GetEnvironmentVariable("ASPNETCORE_HTTP_PORTS");
    if (string.IsNullOrWhiteSpace(configuredPorts))
    {
        return null;
    }

    return configuredPorts.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
        .FirstOrDefault();
}

static void LoadDotEnv(string filePath = ".env")
{
    if (!File.Exists(filePath))
    {
        return;
    }

    foreach (var rawLine in File.ReadAllLines(filePath))
    {
        var line = rawLine.Trim();
        if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#", StringComparison.Ordinal))
        {
            continue;
        }

        var separatorIndex = line.IndexOf('=');
        if (separatorIndex <= 0)
        {
            continue;
        }

        var key = line[..separatorIndex].Trim();
        var value = line[(separatorIndex + 1)..].Trim().Trim('"', '\'');

        // Never replace a value injected by the host, Docker, or the deployment platform.
        if (Environment.GetEnvironmentVariable(key) is null)
        {
            Environment.SetEnvironmentVariable(key, value);
        }
    }
}

static void SetAspNetCoreEnvironmentFromAppMode()
{
    if (!string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")))
    {
        return;
    }

    var appMode = Environment.GetEnvironmentVariable("APP_MODE");
    if (string.IsNullOrWhiteSpace(appMode))
    {
        return;
    }

    var aspNetEnvironment = appMode.ToUpperInvariant() switch
    {
        "DEV" => "Development",
        "TEST" => "Staging",
        "PROD" => "Production",
        _ => appMode
    };

    Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", aspNetEnvironment);
}
