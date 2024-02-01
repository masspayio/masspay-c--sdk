
/**
 * MassPay API
 *
 * The version of the OpenAPI document: 0.1.4
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json.Serialization;
using System.Text.Json;
using MasspaySdk.Core;
namespace MasspaySdk.Models;
public class IdUpload
{
    [JsonPropertyName("type")]
    public required IdUploadType Type { get; init; }
    [JsonPropertyName("content")]
    public required string Content { get; init; }

    /**
     * The type of image being uploaded
     */
    [JsonConverter(typeof(StringValueEnumConverter<IdUploadType>))]
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

