
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
 * MassPay Card Information
 */
public class CardResp
{
    [JsonPropertyName("card_number")]
    [Newtonsoft.Json.JsonProperty("card_number", Required = Newtonsoft.Json.Required.Always)]
    public required string CardNumber { get; init; }
    [JsonPropertyName("cvv")]
    [Newtonsoft.Json.JsonProperty("cvv", Required = Newtonsoft.Json.Required.Always)]
    public required string Cvv { get; init; }
    [JsonPropertyName("expiration_date")]
    [Newtonsoft.Json.JsonProperty("expiration_date", Required = Newtonsoft.Json.Required.Always)]
    public required string ExpirationDate { get; init; }
    [JsonPropertyName("pin_number")]
    [Newtonsoft.Json.JsonProperty("pin_number", Required = Newtonsoft.Json.Required.Always)]
    public required string PinNumber { get; init; }
    [JsonPropertyName("balance")]
    [Newtonsoft.Json.JsonProperty("balance", Required = Newtonsoft.Json.Required.Always)]
    public required double Balance { get; init; }
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
    public required CardRespType Type { get; init; }
    [JsonPropertyName("status")]
    [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
    public required CardRespStatus Status { get; init; }
    /**
     * Card type
     */
    [JsonConverter(typeof(StringValueEnumConverter<CardRespType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

