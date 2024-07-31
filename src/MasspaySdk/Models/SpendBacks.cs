
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
public class SpendBacks
{
    [JsonPropertyName("spendback_token")]
    [Newtonsoft.Json.JsonProperty("spendback_token", Required = Newtonsoft.Json.Required.Always)]
    public required string SpendbackToken { get; init; }
    [JsonPropertyName("time_of_spendback")]
    [Newtonsoft.Json.JsonProperty("time_of_spendback", Required = Newtonsoft.Json.Required.Always)]
    public required string TimeOfSpendback { get; init; }
    [JsonPropertyName("client_spendback_id")]
    [Newtonsoft.Json.JsonProperty("client_spendback_id", Required = Newtonsoft.Json.Required.Always)]
    public required string ClientSpendbackId { get; init; }
    [JsonPropertyName("source_token")]
    [Newtonsoft.Json.JsonProperty("source_token", Required = Newtonsoft.Json.Required.Always)]
    public required string SourceToken { get; init; }
    [JsonPropertyName("wallet_token")]
    [Newtonsoft.Json.JsonProperty("wallet_token", Required = Newtonsoft.Json.Required.Always)]
    public required string WalletToken { get; init; }
    [JsonPropertyName("amount")]
    [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
    public required double Amount { get; init; }
    [JsonPropertyName("source_currency_code")]
    [Newtonsoft.Json.JsonProperty("source_currency_code", Required = Newtonsoft.Json.Required.Always)]
    public required string SourceCurrencyCode { get; init; }
    [JsonPropertyName("notes")]
    [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.Always)]
    public required string Notes { get; init; }
    [JsonPropertyName("metadata")]
    [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.DisallowNull)]
    public IDictionary<string, object> Metadata { get; set; }
}

