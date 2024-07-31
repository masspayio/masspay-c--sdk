
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
public class AllAttributesResp
{
    [JsonPropertyName("destination_token")]
    [Newtonsoft.Json.JsonProperty("destination_token", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string DestinationToken { get; set; }
    [JsonPropertyName("payer_logo")]
    [Newtonsoft.Json.JsonProperty("payer_logo", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string PayerLogo { get; set; }
    [JsonPropertyName("payer_name")]
    [Newtonsoft.Json.JsonProperty("payer_name", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string PayerName { get; set; }
    [JsonPropertyName("exchange_rate")]
    [Newtonsoft.Json.JsonProperty("exchange_rate", Required = Newtonsoft.Json.Required.DisallowNull)]
    public IEnumerable<AllAttributesRespExchangeRate> ExchangeRate { get; set; }
    [JsonPropertyName("max_limit")]
    [Newtonsoft.Json.JsonProperty("max_limit", Required = Newtonsoft.Json.Required.DisallowNull)]
    public double MaxLimit { get; set; }
    [JsonPropertyName("min_limit")]
    [Newtonsoft.Json.JsonProperty("min_limit", Required = Newtonsoft.Json.Required.DisallowNull)]
    public double MinLimit { get; set; }
    [JsonPropertyName("number_of_locations")]
    [Newtonsoft.Json.JsonProperty("number_of_locations", Required = Newtonsoft.Json.Required.DisallowNull)]
    public int NumberOfLocations { get; set; }
    [JsonPropertyName("estimated_availability")]
    [Newtonsoft.Json.JsonProperty("estimated_availability", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string EstimatedAvailability { get; set; }
    [JsonPropertyName("additional_description")]
    [Newtonsoft.Json.JsonProperty("additional_description", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string AdditionalDescription { get; set; }
    [JsonPropertyName("is_dynamic_token")]
    [Newtonsoft.Json.JsonProperty("is_dynamic_token", Required = Newtonsoft.Json.Required.DisallowNull)]
    public bool IsDynamicToken { get; set; }
    [JsonPropertyName("attributes")]
    [Newtonsoft.Json.JsonProperty("attributes", Required = Newtonsoft.Json.Required.DisallowNull)]
    public IEnumerable<AttrsRequirement> Attributes { get; set; }
    public class AllAttributesRespExchangeRate
    {
        [JsonPropertyName("currency_symbol")]
        [Newtonsoft.Json.JsonProperty("currency_symbol", Required = Newtonsoft.Json.Required.Always)]
        public required string CurrencySymbol { get; init; }
        [JsonPropertyName("exchange_rate")]
        [Newtonsoft.Json.JsonProperty("exchange_rate", Required = Newtonsoft.Json.Required.Always)]
        public required double ExchangeRate { get; init; }
    }
    public class AllAttributesRespAttributes { }
}

