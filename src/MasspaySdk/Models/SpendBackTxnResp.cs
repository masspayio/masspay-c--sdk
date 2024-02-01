
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
public class SpendBackTxnResp
{
    [JsonPropertyName("spendback_token")]
    public required string SpendbackToken { get; init; }
    [JsonPropertyName("client_spendback_id")]
    public required string ClientSpendbackId { get; init; }
    [JsonPropertyName("status")]
    public required SpendBackTxnRespStatus Status { get; init; }

    /**
     * Status that indicates whether the transaction was successfully processed. If `success`, everything was processed correctly. `failure` indicates a generic error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<SpendBackTxnRespStatus>))]
    public enum SpendBackTxnRespStatus
    {
        [StringValue("success")]
        SUCCESS,
        [StringValue("failure")]
        FAILURE
    }
}

