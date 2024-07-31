/**
 * MassPay API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace MasspaySdk.Core;

public static class JsonHelpers
{
    public static JObject ParseUtf8JsonReader(ref Utf8JsonReader reader)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        string jsonString = jsonDocument.RootElement.GetRawText();

        return JObject.Parse(jsonString);
    }

    public static JSchema GetJsonSchema(this Type type) => new JSchemaGenerator().Generate(type);
}
