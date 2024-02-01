
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
public class AllAttributesResp
{
    [JsonPropertyName("destination_token")]
    public string? DestinationToken { get; set; }
    [JsonPropertyName("payer_logo")]
    public string? PayerLogo { get; set; }
    [JsonPropertyName("payer_name")]
    public string? PayerName { get; set; }
    [JsonPropertyName("exchange_rate")]
    public IEnumerable<AllAttributesRespExchangeRate?>? ExchangeRate { get; set; }
    [JsonPropertyName("max_limit")]
    public double? MaxLimit { get; set; }
    [JsonPropertyName("min_limit")]
    public double? MinLimit { get; set; }
    [JsonPropertyName("number_of_locations")]
    public int? NumberOfLocations { get; set; }
    [JsonPropertyName("estimated_availability")]
    public string? EstimatedAvailability { get; set; }
    [JsonPropertyName("additional_description")]
    public string? AdditionalDescription { get; set; }
    [JsonPropertyName("is_dynamic_token")]
    public bool? IsDynamicToken { get; set; }
    [JsonPropertyName("attributes")]
    public IEnumerable<AttrsRequirement>? Attributes { get; set; }

    public class AllAttributesRespExchangeRate
    {
        [JsonPropertyName("currency_symbol")]
        public required string CurrencySymbol { get; init; }
        [JsonPropertyName("exchange_rate")]
        public required double ExchangeRate { get; init; }

    }
    public class AllAttributesRespAttributes
    {

    }
}

