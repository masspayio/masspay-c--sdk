
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
public class WalletTxnResp
{
    [JsonPropertyName("user_token")]
    [Newtonsoft.Json.JsonProperty("user_token", Required = Newtonsoft.Json.Required.Always)]
    public required string UserToken { get; init; }
    [JsonPropertyName("token")]
    [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Always)]
    public required string Token { get; init; }
    [JsonPropertyName("balance")]
    [Newtonsoft.Json.JsonProperty("balance", Required = Newtonsoft.Json.Required.Always)]
    public required double Balance { get; init; }
    [JsonPropertyName("currency_code")]
    [Newtonsoft.Json.JsonProperty("currency_code", Required = Newtonsoft.Json.Required.Always)]
    public required string CurrencyCode { get; init; }
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
    public required WalletTxnRespType Type { get; init; }
    [JsonPropertyName("card_type")]
    [Newtonsoft.Json.JsonProperty("card_type", Required = Newtonsoft.Json.Required.DisallowNull)]
    public WalletTxnRespCardType CardType { get; set; }
    [JsonPropertyName("last_4")]
    [Newtonsoft.Json.JsonProperty("last_4", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string Last4 { get; set; }
    [JsonPropertyName("active")]
    [Newtonsoft.Json.JsonProperty("active", Required = Newtonsoft.Json.Required.Always)]
    public required bool Active { get; init; }
    [JsonPropertyName("client_paying_fees")]
    [Newtonsoft.Json.JsonProperty("client_paying_fees", Required = Newtonsoft.Json.Required.DisallowNull)]
    public bool ClientPayingFees { get; set; }
    /**
     * Type of wallet
     */
    [JsonConverter(typeof(StringValueEnumConverter<WalletTxnRespType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WalletTxnRespType
    {
        [StringValue("MASSPAY_CARD")]
        MASSPAY_CARD,
        [StringValue("USER_FUNDS")]
        USER_FUNDS
    }
    /**
     * In case type of wallet is MASSPAY_CARD, card_type would be provided with the type of card it is
     */
    [JsonConverter(typeof(StringValueEnumConverter<WalletTxnRespCardType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WalletTxnRespCardType
    {
        [StringValue("MASTERCARD")]
        MASTERCARD,
        [StringValue("VISA")]
        VISA,
        [StringValue("AMEX")]
        AMEX,
        [StringValue("DISCOVER")]
        DISCOVER,
        [StringValue("UNIONPAY")]
        UNIONPAY
    }
}

