
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
public class SpendBacks
{
    [JsonPropertyName("spendback_token")]
    public required string SpendbackToken { get; init; }
    [JsonPropertyName("time_of_spendback")]
    public required string TimeOfSpendback { get; init; }
    [JsonPropertyName("client_spendback_id")]
    public required string ClientSpendbackId { get; init; }
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
    [JsonPropertyName("metadata")]
    public IDictionary<string, object?>? Metadata { get; set; }

}

