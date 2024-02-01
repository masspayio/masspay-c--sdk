/**
 * MassPay API
 *
 * The version of the OpenAPI document: 0.1.4
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MasspaySdk.Core;

public class StringValueEnumConverter<T> : JsonConverter<T> where T : struct, Enum
{
    public override bool CanConvert(Type objectType)
    {
        return objectType.IsEnum;
    }

    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
      reader.GetString()?.GetEnumFromStringValue<T>() ?? throw new ArgumentException($"Unable to parse {reader.GetString()} as {typeof(T)}");

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        var stringValue = ((Enum)value).GetStringValue();
        writer.WriteStringValue(stringValue);
    }
}
