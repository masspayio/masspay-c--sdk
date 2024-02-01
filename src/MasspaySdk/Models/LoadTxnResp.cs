
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
public class LoadTxnResp
{
    [JsonPropertyName("load_token")]
    public required string LoadToken { get; init; }
    [JsonPropertyName("status")]
    public required LoadTxnRespStatus Status { get; init; }

    /**
     * Status that indicates whether the transaction was successfully processed. If `COMPLETED`, the load was successfully processed. `CANCELLED` indicates a generic error. and `SCHEDULED` means the load was successfully scheduled
     */
    [JsonConverter(typeof(StringValueEnumConverter<LoadTxnRespStatus>))]
    public enum LoadTxnRespStatus
    {
        [StringValue("COMPLETED")]
        COMPLETED,
        [StringValue("CANCELLED")]
        CANCELLED,
        [StringValue("SCHEDULED")]
        SCHEDULED
    }
}

