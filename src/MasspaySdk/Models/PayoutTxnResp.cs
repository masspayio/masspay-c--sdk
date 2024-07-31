
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
public class PayoutTxnResp
{
    [JsonPropertyName("payout_token")]
    [Newtonsoft.Json.JsonProperty("payout_token", Required = Newtonsoft.Json.Required.Always)]
    public required string PayoutToken { get; init; }
    [JsonPropertyName("client_transfer_id")]
    [Newtonsoft.Json.JsonProperty("client_transfer_id", Required = Newtonsoft.Json.Required.Always)]
    public required string ClientTransferId { get; init; }
    [JsonPropertyName("source_currency_code")]
    [Newtonsoft.Json.JsonProperty("source_currency_code", Required = Newtonsoft.Json.Required.Always)]
    public required string SourceCurrencyCode { get; init; }
    [JsonPropertyName("destination_currency_code")]
    [Newtonsoft.Json.JsonProperty("destination_currency_code", Required = Newtonsoft.Json.Required.Always)]
    public required string DestinationCurrencyCode { get; init; }
    [JsonPropertyName("source_token")]
    [Newtonsoft.Json.JsonProperty("source_token", Required = Newtonsoft.Json.Required.Always)]
    public required string SourceToken { get; init; }
    [JsonPropertyName("destination_token")]
    [Newtonsoft.Json.JsonProperty("destination_token", Required = Newtonsoft.Json.Required.Always)]
    public required string DestinationToken { get; init; }
    [JsonPropertyName("destination_amount")]
    [Newtonsoft.Json.JsonProperty("destination_amount", Required = Newtonsoft.Json.Required.Always)]
    public required double DestinationAmount { get; init; }
    [JsonPropertyName("source_amount")]
    [Newtonsoft.Json.JsonProperty("source_amount", Required = Newtonsoft.Json.Required.Always)]
    public required double SourceAmount { get; init; }
    [JsonPropertyName("attr_set_token")]
    [Newtonsoft.Json.JsonProperty("attr_set_token", Required = Newtonsoft.Json.Required.Always)]
    public required string AttrSetToken { get; init; }
    [JsonPropertyName("exchange_rate")]
    [Newtonsoft.Json.JsonProperty("exchange_rate", Required = Newtonsoft.Json.Required.Always)]
    public required double ExchangeRate { get; init; }
    [JsonPropertyName("fee")]
    [Newtonsoft.Json.JsonProperty("fee", Required = Newtonsoft.Json.Required.Always)]
    public required double Fee { get; init; }
    [JsonPropertyName("expiration")]
    [Newtonsoft.Json.JsonProperty("expiration", Required = Newtonsoft.Json.Required.Always)]
    public required string Expiration { get; init; }
    [JsonPropertyName("pickup_code")]
    [Newtonsoft.Json.JsonProperty("pickup_code", Required = Newtonsoft.Json.Required.Always)]
    public required string PickupCode { get; init; }
    [JsonPropertyName("status")]
    [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
    public required PayoutTxnRespStatus Status { get; init; }
    [JsonPropertyName("payer_logo")]
    [Newtonsoft.Json.JsonProperty("payer_logo", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string PayerLogo { get; set; }
    [JsonPropertyName("payer_name")]
    [Newtonsoft.Json.JsonProperty("payer_name", Required = Newtonsoft.Json.Required.Always)]
    public required string PayerName { get; init; }
    [JsonPropertyName("delivery_type")]
    [Newtonsoft.Json.JsonProperty("delivery_type", Required = Newtonsoft.Json.Required.Always)]
    public required PayoutTxnRespDeliveryType DeliveryType { get; init; }
    [JsonPropertyName("country_code")]
    [Newtonsoft.Json.JsonProperty("country_code", Required = Newtonsoft.Json.Required.Always)]
    public required string CountryCode { get; init; }
    [JsonPropertyName("metadata")]
    [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.DisallowNull)]
    public IDictionary<string, object> Metadata { get; set; }
    [JsonPropertyName("estimated_availability")]
    [Newtonsoft.Json.JsonProperty("estimated_availability", Required = Newtonsoft.Json.Required.Always)]
    public required string EstimatedAvailability { get; init; }
    [JsonPropertyName("status_reason")]
    [Newtonsoft.Json.JsonProperty("status_reason", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string StatusReason { get; set; }
    [JsonPropertyName("attrs")]
    [Newtonsoft.Json.JsonProperty("attrs", Required = Newtonsoft.Json.Required.DisallowNull)]
    public IDictionary<string, object> Attrs { get; set; }
    /**
     * The status of the transaction
     */
    [JsonConverter(typeof(StringValueEnumConverter<PayoutTxnRespStatus>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

