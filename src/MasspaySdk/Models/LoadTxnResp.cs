
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
public class LoadTxnResp
{
    [JsonPropertyName("load_token")]
    [Newtonsoft.Json.JsonProperty("load_token", Required = Newtonsoft.Json.Required.Always)]
    public required string LoadToken { get; init; }
    [JsonPropertyName("status")]
    [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
    public required LoadTxnRespStatus Status { get; init; }
    [JsonPropertyName("wallet_token")]
    [Newtonsoft.Json.JsonProperty("wallet_token", Required = Newtonsoft.Json.Required.Always)]
    public required string WalletToken { get; init; }
    /**
     * Status that indicates whether the transaction was successfully processed. If `COMPLETED`, the load was successfully processed. `CANCELLED` indicates a generic error. and `SCHEDULED` means the load was successfully scheduled
     */
    [JsonConverter(typeof(StringValueEnumConverter<LoadTxnRespStatus>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

