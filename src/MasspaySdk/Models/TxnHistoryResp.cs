
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
/**
 * Record that represents a transaction
 */
public class TxnHistoryResp
{
    [JsonPropertyName("token")]
    public required string Token { get; init; }
    [JsonPropertyName("type")]
    public required TxnHistoryRespType Type { get; init; }
    [JsonPropertyName("time_of_txn")]
    public required string TimeOfTxn { get; init; }
    [JsonPropertyName("source_amount")]
    public required double SourceAmount { get; init; }
    [JsonPropertyName("source_currency_code")]
    public required string SourceCurrencyCode { get; init; }
    [JsonPropertyName("destination_amount")]
    public required double DestinationAmount { get; init; }
    [JsonPropertyName("destination_currency_code")]
    public required string DestinationCurrencyCode { get; init; }
    [JsonPropertyName("fee")]
    public required double Fee { get; init; }
    [JsonPropertyName("status")]
    public required TxnHistoryRespStatus Status { get; init; }
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }
    [JsonPropertyName("payer_name")]
    public string? PayerName { get; set; }
    [JsonPropertyName("pickup_code")]
    public string? PickupCode { get; set; }
    [JsonPropertyName("source_token")]
    public string? SourceToken { get; set; }
    [JsonPropertyName("destination_token")]
    public required string DestinationToken { get; init; }
    [JsonPropertyName("delivery_type")]
    public TxnHistoryRespDeliveryType? DeliveryType { get; set; }
    [JsonPropertyName("client_transfer_id")]
    public string? ClientTransferId { get; set; }
    [JsonPropertyName("status_reason")]
    public string? StatusReason { get; set; }
    [JsonPropertyName("client_id")]
    public int? ClientId { get; set; }

    /**
     * Type of transaction
     */
    [JsonConverter(typeof(StringValueEnumConverter<TxnHistoryRespType>))]
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

