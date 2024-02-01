
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
public class Service
{
    [JsonPropertyName("country_code")]
    public required string CountryCode { get; init; }
    [JsonPropertyName("delivery_type")]
    public required ServiceDeliveryType DeliveryType { get; init; }
    [JsonPropertyName("payers")]
    public required IEnumerable<ServicePayers?> Payers { get; init; }

    /**
     * The type of service. I.e. cash pickup, home delivery, etc.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ServiceDeliveryType>))]
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
        public required string DestinationToken { get; init; }
        [JsonPropertyName("payer_logo")]
        public required string PayerLogo { get; init; }
        [JsonPropertyName("payer_name")]
        public required string PayerName { get; init; }
        [JsonPropertyName("exchange_rate")]
        public required IEnumerable<ServicePayersExchangeRate?> ExchangeRate { get; init; }
        [JsonPropertyName("fee")]
        public required double Fee { get; init; }
        [JsonPropertyName("max_limit")]
        public required double MaxLimit { get; init; }
        [JsonPropertyName("min_limit")]
        public required double MinLimit { get; init; }
        [JsonPropertyName("source_amount")]
        public double? SourceAmount { get; set; }
        [JsonPropertyName("number_of_locations")]
        public int? NumberOfLocations { get; set; }
        [JsonPropertyName("estimated_availability")]
        public string? EstimatedAvailability { get; set; }
        [JsonPropertyName("additional_description")]
        public string? AdditionalDescription { get; set; }
        [JsonPropertyName("is_dynamic_token")]
        public bool? IsDynamicToken { get; set; }

        public class ServicePayersExchangeRate
        {
            [JsonPropertyName("currency_symbol")]
            public required string CurrencySymbol { get; init; }
            [JsonPropertyName("exchange_rate")]
            public required double ExchangeRate { get; init; }

        }
    }
}

