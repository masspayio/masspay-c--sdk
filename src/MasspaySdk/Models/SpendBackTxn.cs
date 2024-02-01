
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
public class SpendBackTxn
{
    [JsonPropertyName("client_spendback_id")]
    public required string ClientSpendbackId { get; init; }
    [JsonPropertyName("source_token")]
    public required string SourceToken { get; init; }
    [JsonPropertyName("source_currency_code")]
    public required string SourceCurrencyCode { get; init; }
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }
    [JsonPropertyName("metadata")]
    public IDictionary<string, object?>? Metadata { get; set; }

}

