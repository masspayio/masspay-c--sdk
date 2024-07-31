
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
public class LoadTxn
{
    [JsonPropertyName("client_load_id")]
    [Newtonsoft.Json.JsonProperty("client_load_id", Required = Newtonsoft.Json.Required.Always)]
    public required string ClientLoadId { get; init; }
    [JsonPropertyName("source_token")]
    [Newtonsoft.Json.JsonProperty("source_token", Required = Newtonsoft.Json.Required.Always)]
    public required string SourceToken { get; init; }
    [JsonPropertyName("amount")]
    [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
    public required double Amount { get; init; }
    [JsonPropertyName("source_currency_code")]
    [Newtonsoft.Json.JsonProperty("source_currency_code", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string SourceCurrencyCode { get; set; }
    [JsonPropertyName("notes")]
    [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string Notes { get; set; }
    [JsonPropertyName("notify_user")]
    [Newtonsoft.Json.JsonProperty("notify_user", Required = Newtonsoft.Json.Required.DisallowNull)]
    public bool NotifyUser { get; set; }
    [JsonPropertyName("time_to_process")]
    [Newtonsoft.Json.JsonProperty("time_to_process", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string TimeToProcess { get; set; }
    [JsonPropertyName("metadata")]
    [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.DisallowNull)]
    public IDictionary<string, object> Metadata { get; set; }
}

