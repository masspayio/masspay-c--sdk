
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
public class PayoutTxn
{
    [JsonPropertyName("client_transfer_id")]
    public string? ClientTransferId { get; set; }
    [JsonPropertyName("source_currency_code")]
    public string? SourceCurrencyCode { get; set; }
    [JsonPropertyName("destination_currency_code")]
    public required string DestinationCurrencyCode { get; init; }
    [JsonPropertyName("source_token")]
    public required string SourceToken { get; init; }
    [JsonPropertyName("destination_token")]
    public required string DestinationToken { get; init; }
    [JsonPropertyName("destination_amount")]
    public double? DestinationAmount { get; set; }
    [JsonPropertyName("source_amount")]
    public double? SourceAmount { get; set; }
    [JsonPropertyName("attr_set_token")]
    public string? AttrSetToken { get; set; }
    [JsonPropertyName("metadata")]
    public IDictionary<string, object?>? Metadata { get; set; }
    [JsonPropertyName("notify_user")]
    public bool? NotifyUser { get; set; }

}

