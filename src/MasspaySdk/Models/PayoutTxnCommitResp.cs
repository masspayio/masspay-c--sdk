
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
public class PayoutTxnCommitResp
{
    [JsonPropertyName("payout_token")]
    public required string PayoutToken { get; init; }
    [JsonPropertyName("status")]
    public required PayoutTxnCommitRespStatus Status { get; init; }
    [JsonPropertyName("pickup_code")]
    public string? PickupCode { get; set; }
    [JsonPropertyName("errors")]
    public string? Errors { get; set; }

    /**
     * Status that indicates whether the transaction was successfully processed. If `success`, everything was processed correctly. `failure` indicates a generic error. `addtl_attr_req` indicates that in order to process this transaction, additional attributes are required to be updated for this customer. `ex_rate_expired` indicates that the transaction exchange rate has expired and a new transaction has to be created.
     */
    [JsonConverter(typeof(StringValueEnumConverter<PayoutTxnCommitRespStatus>))]
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

