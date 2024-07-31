
/**
 * MassPay API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Schema;
using MasspaySdk.Core;
namespace MasspaySdk.Models;
public class IdUpload
{
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
    public required IdUploadType Type { get; init; }
    [JsonPropertyName("content")]
    [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.Always)]
    public required string Content { get; init; }
    /**
     * The type of image being uploaded
     */
    [JsonConverter(typeof(StringValueEnumConverter<IdUploadType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IdUploadType
    {
        [StringValue("face")]
        FACE,
        [StringValue("document-front")]
        DOCUMENT_FRONT,
        [StringValue("document-back")]
        DOCUMENT_BACK
    }
}

