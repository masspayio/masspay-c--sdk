
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
public class AddUboRequest
{
    [JsonPropertyName("ownership_percentage")]
    [Newtonsoft.Json.JsonProperty("ownership_percentage", Required = Newtonsoft.Json.Required.Always)]
    public required double OwnershipPercentage { get; init; }
    [JsonPropertyName("phone")]
    [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.Always)]
    public required string Phone { get; init; }
    [JsonPropertyName("first_name")]
    [Newtonsoft.Json.JsonProperty("first_name", Required = Newtonsoft.Json.Required.Always)]
    public required string FirstName { get; init; }
    [JsonPropertyName("middle_name")]
    [Newtonsoft.Json.JsonProperty("middle_name", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string MiddleName { get; set; }
    [JsonPropertyName("last_name")]
    [Newtonsoft.Json.JsonProperty("last_name", Required = Newtonsoft.Json.Required.Always)]
    public required string LastName { get; init; }
    [JsonPropertyName("email")]
    [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Always)]
    public required string Email { get; init; }
    [JsonPropertyName("dob")]
    [Newtonsoft.Json.JsonProperty("dob", Required = Newtonsoft.Json.Required.Always)]
    public required string Dob { get; init; }
    [JsonPropertyName("tax_id")]
    [Newtonsoft.Json.JsonProperty("tax_id", Required = Newtonsoft.Json.Required.Always)]
    public required string TaxId { get; init; }
    [JsonPropertyName("address1")]
    [Newtonsoft.Json.JsonProperty("address1", Required = Newtonsoft.Json.Required.Always)]
    public required string Address1 { get; init; }
    [JsonPropertyName("address2")]
    [Newtonsoft.Json.JsonProperty("address2", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string Address2 { get; set; }
    [JsonPropertyName("city")]
    [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Always)]
    public required string City { get; init; }
    [JsonPropertyName("state")]
    [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Always)]
    public required string State { get; init; }
    [JsonPropertyName("zip")]
    [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Always)]
    public required string Zip { get; init; }
    [JsonPropertyName("country")]
    [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Always)]
    public required string Country { get; init; }
}

