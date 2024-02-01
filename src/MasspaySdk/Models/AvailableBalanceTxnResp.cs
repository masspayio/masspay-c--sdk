
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
public class AvailableBalanceTxnResp
{
    [JsonPropertyName("token")]
    public required string Token { get; init; }
    [JsonPropertyName("balance")]
    public required double Balance { get; init; }
    [JsonPropertyName("currency_code")]
    public required string CurrencyCode { get; init; }

}

