
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
/**
 * Record that represents a transaction
 */
public class TxnHistoryResp
{
    [JsonPropertyName("token")]
    [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Always)]
    public required string Token { get; init; }
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
    public required TxnHistoryRespType Type { get; init; }
    [JsonPropertyName("time_of_txn")]
    [Newtonsoft.Json.JsonProperty("time_of_txn", Required = Newtonsoft.Json.Required.Always)]
    public required string TimeOfTxn { get; init; }
    [JsonPropertyName("source_amount")]
    [Newtonsoft.Json.JsonProperty("source_amount", Required = Newtonsoft.Json.Required.Always)]
    public required double SourceAmount { get; init; }
    [JsonPropertyName("source_currency_code")]
    [Newtonsoft.Json.JsonProperty("source_currency_code", Required = Newtonsoft.Json.Required.Always)]
    public required string SourceCurrencyCode { get; init; }
    [JsonPropertyName("destination_amount")]
    [Newtonsoft.Json.JsonProperty("destination_amount", Required = Newtonsoft.Json.Required.Always)]
    public required double DestinationAmount { get; init; }
    [JsonPropertyName("destination_currency_code")]
    [Newtonsoft.Json.JsonProperty("destination_currency_code", Required = Newtonsoft.Json.Required.Always)]
    public required string DestinationCurrencyCode { get; init; }
    [JsonPropertyName("fee")]
    [Newtonsoft.Json.JsonProperty("fee", Required = Newtonsoft.Json.Required.Always)]
    public required double Fee { get; init; }
    [JsonPropertyName("status")]
    [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
    public required TxnHistoryRespStatus Status { get; init; }
    [JsonPropertyName("notes")]
    [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string Notes { get; set; }
    [JsonPropertyName("payer_name")]
    [Newtonsoft.Json.JsonProperty("payer_name", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string PayerName { get; set; }
    [JsonPropertyName("pickup_code")]
    [Newtonsoft.Json.JsonProperty("pickup_code", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string PickupCode { get; set; }
    [JsonPropertyName("source_token")]
    [Newtonsoft.Json.JsonProperty("source_token", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string SourceToken { get; set; }
    [JsonPropertyName("destination_token")]
    [Newtonsoft.Json.JsonProperty("destination_token", Required = Newtonsoft.Json.Required.Always)]
    public required string DestinationToken { get; init; }
    [JsonPropertyName("delivery_type")]
    [Newtonsoft.Json.JsonProperty("delivery_type", Required = Newtonsoft.Json.Required.DisallowNull)]
    public TxnHistoryRespDeliveryType DeliveryType { get; set; }
    [JsonPropertyName("client_transfer_id")]
    [Newtonsoft.Json.JsonProperty("client_transfer_id", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string ClientTransferId { get; set; }
    [JsonPropertyName("status_reason")]
    [Newtonsoft.Json.JsonProperty("status_reason", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string StatusReason { get; set; }
    [JsonPropertyName("client_id")]
    [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull)]
    public int ClientId { get; set; }
    [JsonPropertyName("user_token")]
    [Newtonsoft.Json.JsonProperty("user_token", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string UserToken { get; set; }
    /**
     * Type of transaction
     */
    [JsonConverter(typeof(StringValueEnumConverter<TxnHistoryRespType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TxnHistoryRespType
    {
        [StringValue("load")]
        LOAD,
        [StringValue("payout")]
        PAYOUT,
        [StringValue("spend back")]
        SPEND_BACK,
        [StringValue("info")]
        INFO
    }
    /**
     * Status of the transaction
     */
    [JsonConverter(typeof(StringValueEnumConverter<TxnHistoryRespStatus>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TxnHistoryRespStatus
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
     * The type of service. I.e. cash pickup, home delivery, etc. Only provided for payouts
     */
    [JsonConverter(typeof(StringValueEnumConverter<TxnHistoryRespDeliveryType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TxnHistoryRespDeliveryType
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

