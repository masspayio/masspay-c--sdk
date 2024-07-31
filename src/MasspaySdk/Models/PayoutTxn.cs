
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
public class PayoutTxn
{
    [JsonPropertyName("client_transfer_id")]
    [Newtonsoft.Json.JsonProperty("client_transfer_id", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string ClientTransferId { get; set; }
    [JsonPropertyName("source_currency_code")]
    [Newtonsoft.Json.JsonProperty("source_currency_code", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string SourceCurrencyCode { get; set; }
    [JsonPropertyName("destination_currency_code")]
    [Newtonsoft.Json.JsonProperty("destination_currency_code", Required = Newtonsoft.Json.Required.Always)]
    public required string DestinationCurrencyCode { get; init; }
    [JsonPropertyName("source_token")]
    [Newtonsoft.Json.JsonProperty("source_token", Required = Newtonsoft.Json.Required.Always)]
    public required string SourceToken { get; init; }
    [JsonPropertyName("destination_token")]
    [Newtonsoft.Json.JsonProperty("destination_token", Required = Newtonsoft.Json.Required.Always)]
    public required string DestinationToken { get; init; }
    [JsonPropertyName("destination_amount")]
    [Newtonsoft.Json.JsonProperty("destination_amount", Required = Newtonsoft.Json.Required.DisallowNull)]
    public double DestinationAmount { get; set; }
    [JsonPropertyName("source_amount")]
    [Newtonsoft.Json.JsonProperty("source_amount", Required = Newtonsoft.Json.Required.DisallowNull)]
    public double SourceAmount { get; set; }
    [JsonPropertyName("attr_set_token")]
    [Newtonsoft.Json.JsonProperty("attr_set_token", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string AttrSetToken { get; set; }
    [JsonPropertyName("metadata")]
    [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.DisallowNull)]
    public IDictionary<string, object> Metadata { get; set; }
    [JsonPropertyName("notify_user")]
    [Newtonsoft.Json.JsonProperty("notify_user", Required = Newtonsoft.Json.Required.DisallowNull)]
    public bool NotifyUser { get; set; }
    [JsonPropertyName("auto_commit")]
    [Newtonsoft.Json.JsonProperty("auto_commit", Required = Newtonsoft.Json.Required.DisallowNull)]
    public bool AutoCommit { get; set; }
}

