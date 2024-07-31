
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
public class AvailableBalanceTxnResp
{
    [JsonPropertyName("token")]
    [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Always)]
    public required string Token { get; init; }
    [JsonPropertyName("balance")]
    [Newtonsoft.Json.JsonProperty("balance", Required = Newtonsoft.Json.Required.Always)]
    public required double Balance { get; init; }
    [JsonPropertyName("currency_code")]
    [Newtonsoft.Json.JsonProperty("currency_code", Required = Newtonsoft.Json.Required.Always)]
    public required string CurrencyCode { get; init; }
}

