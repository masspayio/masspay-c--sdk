
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
public class PayoutTxnCommitResp
{
    [JsonPropertyName("payout_token")]
    [Newtonsoft.Json.JsonProperty("payout_token", Required = Newtonsoft.Json.Required.Always)]
    public required string PayoutToken { get; init; }
    [JsonPropertyName("status")]
    [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
    public required PayoutTxnCommitRespStatus Status { get; init; }
    [JsonPropertyName("pickup_code")]
    [Newtonsoft.Json.JsonProperty("pickup_code", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string PickupCode { get; set; }
    [JsonPropertyName("errors")]
    [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string Errors { get; set; }
    /**
     * Status that indicates whether the transaction was successfully processed. If `success`, everything was processed correctly. `failure` indicates a generic error. `addtl_attr_req` indicates that in order to process this transaction, additional attributes are required to be updated for this customer. `ex_rate_expired` indicates that the transaction exchange rate has expired and a new transaction has to be created.
     */
    [JsonConverter(typeof(StringValueEnumConverter<PayoutTxnCommitRespStatus>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PayoutTxnCommitRespStatus
    {
        [StringValue("success")]
        SUCCESS,
        [StringValue("failure")]
        FAILURE,
        [StringValue("addtl_attr_req")]
        ADDTL_ATTR_REQ,
        [StringValue("ex_rate_expired")]
        EX_RATE_EXPIRED,
        [StringValue("nsf")]
        NSF
    }
}

