
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
public class SpendBackTxnResp
{
    [JsonPropertyName("spendback_token")]
    [Newtonsoft.Json.JsonProperty("spendback_token", Required = Newtonsoft.Json.Required.Always)]
    public required string SpendbackToken { get; init; }
    [JsonPropertyName("client_spendback_id")]
    [Newtonsoft.Json.JsonProperty("client_spendback_id", Required = Newtonsoft.Json.Required.Always)]
    public required string ClientSpendbackId { get; init; }
    [JsonPropertyName("status")]
    [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
    public required SpendBackTxnRespStatus Status { get; init; }
    /**
     * Status that indicates whether the transaction was successfully processed. If `success`, everything was processed correctly. `failure` indicates a generic error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<SpendBackTxnRespStatus>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SpendBackTxnRespStatus
    {
        [StringValue("success")]
        SUCCESS,
        [StringValue("failure")]
        FAILURE
    }
}

