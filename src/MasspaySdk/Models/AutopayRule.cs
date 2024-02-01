
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
public class AutopayRule
{
    [JsonPropertyName("destination_token")]
    public required string DestinationToken { get; init; }
    [JsonPropertyName("percentage")]
    public required double Percentage { get; init; }

}

