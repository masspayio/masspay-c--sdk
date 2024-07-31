
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
public class AutopayRule
{
    [JsonPropertyName("destination_token")]
    [Newtonsoft.Json.JsonProperty("destination_token", Required = Newtonsoft.Json.Required.Always)]
    public required string DestinationToken { get; init; }
    [JsonPropertyName("percentage")]
    [Newtonsoft.Json.JsonProperty("percentage", Required = Newtonsoft.Json.Required.Always)]
    public required double Percentage { get; init; }
    [JsonPropertyName("attr_set_token")]
    [Newtonsoft.Json.JsonProperty("attr_set_token", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string AttrSetToken { get; set; }
}

