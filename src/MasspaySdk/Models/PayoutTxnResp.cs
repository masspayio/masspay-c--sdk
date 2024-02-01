
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
public class PayoutTxnResp
{
    [JsonPropertyName("payout_token")]
    public required string PayoutToken { get; init; }
    [JsonPropertyName("client_transfer_id")]
    public required string ClientTransferId { get; init; }
    [JsonPropertyName("source_currency_code")]
    public required string SourceCurrencyCode { get; init; }
    [JsonPropertyName("destination_currency_code")]
    public required string DestinationCurrencyCode { get; init; }
    [JsonPropertyName("source_token")]
    public required string SourceToken { get; init; }
    [JsonPropertyName("destination_token")]
    public required string DestinationToken { get; init; }
    [JsonPropertyName("destination_amount")]
    public required double DestinationAmount { get; init; }
    [JsonPropertyName("source_amount")]
    public required double SourceAmount { get; init; }
    [JsonPropertyName("attr_set_token")]
    public required string AttrSetToken { get; init; }
    [JsonPropertyName("exchange_rate")]
    public required double ExchangeRate { get; init; }
    [JsonPropertyName("fee")]
    public required double Fee { get; init; }
    [JsonPropertyName("expiration")]
    public required string Expiration { get; init; }
    [JsonPropertyName("pickup_code")]
    public required string PickupCode { get; init; }
    [JsonPropertyName("status")]
    public required PayoutTxnRespStatus Status { get; init; }
    [JsonPropertyName("payer_logo")]
    public string? PayerLogo { get; set; }
    [JsonPropertyName("payer_name")]
    public required string PayerName { get; init; }
    [JsonPropertyName("delivery_type")]
    public required PayoutTxnRespDeliveryType DeliveryType { get; init; }
    [JsonPropertyName("country_code")]
    public required string CountryCode { get; init; }
    [JsonPropertyName("metadata")]
    public IDictionary<string, object?>? Metadata { get; set; }
    [JsonPropertyName("estimated_availability")]
    public required string EstimatedAvailability { get; init; }
    [JsonPropertyName("status_reason")]
    public string? StatusReason { get; set; }
    [JsonPropertyName("attrs")]
    public IDictionary<string, object?>? Attrs { get; set; }

    /**
     * The status of the transaction
     */
    [JsonConverter(typeof(StringValueEnumConverter<PayoutTxnRespStatus>))]
    public enum PayoutTxnRespStatus
    {
        [StringValue("PENDING")]
        PENDING,
        [StringValue("PROCESSING")]
        PROCESSING,
        [StringValue("COMPLETED")]
        COMPLETED,
        [StringValue("CANCELLED")]
        CANCELLED,
        [StringValue("SCHEDULED")]
        SCHEDULED,
        [StringValue("READY_FOR_PICKUP")]
        READY_FOR_PICKUP,
        [StringValue("HOLD")]
        HOLD,
        [StringValue("ERROR")]
        ERROR
    }
    /**
     * The type of delivery
     */
    [JsonConverter(typeof(StringValueEnumConverter<PayoutTxnRespDeliveryType>))]
    public enum PayoutTxnRespDeliveryType
    {
        [StringValue("CASH_PICKUP")]
        CASH_PICKUP,
        [StringValue("BANK_DEPOSIT")]
        BANK_DEPOSIT,
        [StringValue("HOME_DELIVERY")]
        HOME_DELIVERY,
        [StringValue("MOBILE_WALLET")]
        MOBILE_WALLET,
        [StringValue("MASSPAY_CARD")]
        MASSPAY_CARD,
        [StringValue("PAPER_CHECK")]
        PAPER_CHECK,
        [StringValue("BILL")]
        BILL,
        [StringValue("CRYPTOCURRENCY")]
        CRYPTOCURRENCY
    }
}

