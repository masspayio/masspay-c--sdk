
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
public class Company
{
    [JsonPropertyName("company_logo")]
    [Newtonsoft.Json.JsonProperty("company_logo", Required = Newtonsoft.Json.Required.Always)]
    public required string CompanyLogo { get; init; }
    [JsonPropertyName("services")]
    [Newtonsoft.Json.JsonProperty("services", Required = Newtonsoft.Json.Required.Always)]
    public required IEnumerable<Service> Services { get; init; }
    [JsonPropertyName("rating")]
    [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Always)]
    public required double Rating { get; init; }
    [JsonPropertyName("description")]
    [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
    public required string Description { get; init; }
    [JsonPropertyName("company_name")]
    [Newtonsoft.Json.JsonProperty("company_name", Required = Newtonsoft.Json.Required.Always)]
    public required string CompanyName { get; init; }
    public class CompanyServices { }
}

