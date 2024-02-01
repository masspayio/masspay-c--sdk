
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
public class Loads
{
    [JsonPropertyName("load_token")]
    public required string LoadToken { get; init; }
    [JsonPropertyName("time_of_load")]
    public required string TimeOfLoad { get; init; }
    [JsonPropertyName("client_load_id")]
    public required string ClientLoadId { get; init; }
    [JsonPropertyName("source_token")]
    public required string SourceToken { get; init; }
    [JsonPropertyName("wallet_token")]
    public required string WalletToken { get; init; }
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }
    [JsonPropertyName("source_currency_code")]
    public required string SourceCurrencyCode { get; init; }
    [JsonPropertyName("notes")]
    public required string Notes { get; init; }
    [JsonPropertyName("status")]
    public required LoadsStatus Status { get; init; }
    [JsonPropertyName("metadata")]
    public IDictionary<string, object?>? Metadata { get; set; }

    /**
     * Status of the load
     */
    [JsonConverter(typeof(StringValueEnumConverter<LoadsStatus>))]
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

