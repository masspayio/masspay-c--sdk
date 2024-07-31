
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
public class Loads
{
    [JsonPropertyName("load_token")]
    [Newtonsoft.Json.JsonProperty("load_token", Required = Newtonsoft.Json.Required.Always)]
    public required string LoadToken { get; init; }
    [JsonPropertyName("time_of_load")]
    [Newtonsoft.Json.JsonProperty("time_of_load", Required = Newtonsoft.Json.Required.Always)]
    public required string TimeOfLoad { get; init; }
    [JsonPropertyName("client_load_id")]
    [Newtonsoft.Json.JsonProperty("client_load_id", Required = Newtonsoft.Json.Required.Always)]
    public required string ClientLoadId { get; init; }
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
    [JsonPropertyName("status")]
    [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
    public required LoadsStatus Status { get; init; }
    [JsonPropertyName("metadata")]
    [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.DisallowNull)]
    public IDictionary<string, object> Metadata { get; set; }
    /**
     * Status of the load
     */
    [JsonConverter(typeof(StringValueEnumConverter<LoadsStatus>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LoadsStatus
    {
        [StringValue("COMPLETED")]
        COMPLETED,
        [StringValue("CANCELLED")]
        CANCELLED,
        [StringValue("SCHEDULED")]
        SCHEDULED
    }
}

