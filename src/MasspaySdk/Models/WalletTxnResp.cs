
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
public class WalletTxnResp
{
    [JsonPropertyName("user_token")]
    public required string UserToken { get; init; }
    [JsonPropertyName("token")]
    public required string Token { get; init; }
    [JsonPropertyName("balance")]
    public required double Balance { get; init; }
    [JsonPropertyName("currency_code")]
    public required string CurrencyCode { get; init; }
    [JsonPropertyName("type")]
    public required WalletTxnRespType Type { get; init; }
    [JsonPropertyName("card_type")]
    public WalletTxnRespCardType? CardType { get; set; }
    [JsonPropertyName("last_4")]
    public string? Last4 { get; set; }
    [JsonPropertyName("active")]
    public required bool Active { get; init; }
    [JsonPropertyName("client_paying_fees")]
    public bool? ClientPayingFees { get; set; }

    /**
     * Type of wallet
     */
    [JsonConverter(typeof(StringValueEnumConverter<WalletTxnRespType>))]
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

