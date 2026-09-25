using System.Globalization;
using System.Text.Json;

namespace SIHSALUS_DocumentGenerator.Utils;

public static class MappingUtils
{
    /// <summary>
    /// Gets a value from a JSON object using a dot-separated path. Object properties
    /// and zero-based array indices are both supported (for example,
    /// <c>person.list.1.id</c>).
    /// </summary>
    /// <param name="jsonObject">The JSON object to search.</param>
    /// <param name="path">The dot-separated path to the requested value.</param>
    /// <returns>
    /// A cloned <see cref="JsonElement"/> for JSON objects and arrays; a native
    /// <see cref="string"/>, numeric value, or <see cref="bool"/> for scalar values;
    /// otherwise <see langword="null"/> when the path cannot be resolved or its value
    /// is JSON <see langword="null"/>.
    /// </returns>
    public static object? GetValueByPath(JsonElement jsonObject, string path)
    {
        if (jsonObject.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined ||
            string.IsNullOrWhiteSpace(path))
        {
            return null;
        }

        JsonElement current = jsonObject;

        foreach (string segment in path.Split('.', StringSplitOptions.TrimEntries))
        {
            if (segment.Length == 0)
            {
                return null;
            }

            if (current.ValueKind == JsonValueKind.Object &&
                current.TryGetProperty(segment, out JsonElement property))
            {
                current = property;
                continue;
            }

            if (current.ValueKind == JsonValueKind.Array &&
                int.TryParse(segment, NumberStyles.None, CultureInfo.InvariantCulture, out int index) &&
                index >= 0 &&
                index < current.GetArrayLength())
            {
                current = current[index];
                continue;
            }

            return null;
        }

        return current.ValueKind switch
        {
            JsonValueKind.Object or JsonValueKind.Array => current.Clone(),
            JsonValueKind.String => current.GetString(),
            JsonValueKind.Number => GetNumber(current),
            JsonValueKind.True => true,
            JsonValueKind.False => false,
            _ => null
        };
    }

    private static object GetNumber(JsonElement value)
    {
        if (value.TryGetInt32(out int intValue))
        {
            return intValue;
        }

        if (value.TryGetInt64(out long longValue))
        {
            return longValue;
        }

        if (value.TryGetDecimal(out decimal decimalValue))
        {
            return decimalValue;
        }

        return value.GetDouble();
    }
}
