
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
public class LoadTxn
{
    [JsonPropertyName("client_load_id")]
    public required string ClientLoadId { get; init; }
    [JsonPropertyName("source_token")]
    public required string SourceToken { get; init; }
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }
    [JsonPropertyName("source_currency_code")]
    public string? SourceCurrencyCode { get; set; }
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }
    [JsonPropertyName("notify_user")]
    public bool? NotifyUser { get; set; }
    [JsonPropertyName("time_to_process")]
    public string? TimeToProcess { get; set; }
    [JsonPropertyName("metadata")]
    public IDictionary<string, object?>? Metadata { get; set; }

}

