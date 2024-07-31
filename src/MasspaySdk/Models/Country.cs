
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
public class Country
{
    [JsonPropertyName("code")]
    [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
    public required string Code { get; init; }
    [JsonPropertyName("name")]
    [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
    public required string Name { get; init; }
    [JsonPropertyName("three_letter_code")]
    [Newtonsoft.Json.JsonProperty("three_letter_code", Required = Newtonsoft.Json.Required.Always)]
    public required string ThreeLetterCode { get; init; }
}

