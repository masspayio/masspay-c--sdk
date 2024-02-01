
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
 * MassPay Card Information
 */
public class CardResp
{
    [JsonPropertyName("card_number")]
    public required string CardNumber { get; init; }
    [JsonPropertyName("cvv")]
    public required string Cvv { get; init; }
    [JsonPropertyName("expiration_date")]
    public required string ExpirationDate { get; init; }
    [JsonPropertyName("pin_number")]
    public required string PinNumber { get; init; }
    [JsonPropertyName("balance")]
    public required double Balance { get; init; }
    [JsonPropertyName("type")]
    public required CardRespType Type { get; init; }
    [JsonPropertyName("status")]
    public required CardRespStatus Status { get; init; }

    /**
     * Card type
     */
    [JsonConverter(typeof(StringValueEnumConverter<CardRespType>))]
    public enum CardRespType
    {
        [StringValue("VISA")]
        VISA,
        [StringValue("MASTERCARD")]
        MASTERCARD,
        [StringValue("DISCOVER")]
        DISCOVER,
        [StringValue("AMEX")]
        AMEX,
        [StringValue("UNIONPAY")]
        UNIONPAY
    }
    /**
     * Status of the card
     */
    [JsonConverter(typeof(StringValueEnumConverter<CardRespStatus>))]
    public enum CardRespStatus
    {
        [StringValue("ACTIVE")]
        ACTIVE,
        [StringValue("INACTIVE")]
        INACTIVE,
        [StringValue("CLOSED")]
        CLOSED
    }
}

