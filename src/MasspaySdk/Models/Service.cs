
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
public class Service
{
    [JsonPropertyName("country_code")]
    [Newtonsoft.Json.JsonProperty("country_code", Required = Newtonsoft.Json.Required.Always)]
    public required string CountryCode { get; init; }
    [JsonPropertyName("delivery_type")]
    [Newtonsoft.Json.JsonProperty("delivery_type", Required = Newtonsoft.Json.Required.Always)]
    public required ServiceDeliveryType DeliveryType { get; init; }
    [JsonPropertyName("payers")]
    [Newtonsoft.Json.JsonProperty("payers", Required = Newtonsoft.Json.Required.Always)]
    public required IEnumerable<ServicePayers> Payers { get; init; }
    /**
     * The type of service. I.e. cash pickup, home delivery, etc.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ServiceDeliveryType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ServiceDeliveryType
    {
        [StringValue("CASH_PICKUP")]
        CASH_PICKUP,
        [StringValue("BANK_DEPOSIT")]
        BANK_DEPOSIT,
        [StringValue("HOME_DELIVERY")]
        HOME_DELIVERY,
        [StringValue("MOBILE_WALLET")]
        MOBILE_WALLET,
        [StringValue("MASSPAY_CARD")]
        MASSPAY_CARD,
        [StringValue("PAPER_CHECK")]
        PAPER_CHECK,
        [StringValue("BILL")]
        BILL,
        [StringValue("CRYPTOCURRENCY")]
        CRYPTOCURRENCY
    }
    public class ServicePayers
    {
        [JsonPropertyName("destination_token")]
        [Newtonsoft.Json.JsonProperty("destination_token", Required = Newtonsoft.Json.Required.Always)]
        public required string DestinationToken { get; init; }
        [JsonPropertyName("payer_logo")]
        [Newtonsoft.Json.JsonProperty("payer_logo", Required = Newtonsoft.Json.Required.DisallowNull)]
        public string PayerLogo { get; set; }
        [JsonPropertyName("payer_name")]
        [Newtonsoft.Json.JsonProperty("payer_name", Required = Newtonsoft.Json.Required.Always)]
        public required string PayerName { get; init; }
        [JsonPropertyName("exchange_rate")]
        [Newtonsoft.Json.JsonProperty("exchange_rate", Required = Newtonsoft.Json.Required.Always)]
        public required IEnumerable<ServicePayersExchangeRate> ExchangeRate { get; init; }
        [JsonPropertyName("fee")]
        [Newtonsoft.Json.JsonProperty("fee", Required = Newtonsoft.Json.Required.Always)]
        public required double Fee { get; init; }
        [JsonPropertyName("max_limit")]
        [Newtonsoft.Json.JsonProperty("max_limit", Required = Newtonsoft.Json.Required.Always)]
        public required double MaxLimit { get; init; }
        [JsonPropertyName("min_limit")]
        [Newtonsoft.Json.JsonProperty("min_limit", Required = Newtonsoft.Json.Required.Always)]
        public required double MinLimit { get; init; }
        [JsonPropertyName("source_amount")]
        [Newtonsoft.Json.JsonProperty("source_amount", Required = Newtonsoft.Json.Required.DisallowNull)]
        public double SourceAmount { get; set; }
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
        public class ServicePayersExchangeRate
        {
            [JsonPropertyName("currency_symbol")]
            [Newtonsoft.Json.JsonProperty("currency_symbol", Required = Newtonsoft.Json.Required.Always)]
            public required string CurrencySymbol { get; init; }
            [JsonPropertyName("exchange_rate")]
            [Newtonsoft.Json.JsonProperty("exchange_rate", Required = Newtonsoft.Json.Required.Always)]
            public required double ExchangeRate { get; init; }
        }
    }
}

