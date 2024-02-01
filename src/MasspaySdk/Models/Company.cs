
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
public class Company
{
    [JsonPropertyName("company_logo")]
    public required string CompanyLogo { get; init; }
    [JsonPropertyName("services")]
    public required IEnumerable<Service> Services { get; init; }
    [JsonPropertyName("rating")]
    public required double Rating { get; init; }
    [JsonPropertyName("description")]
    public required string Description { get; init; }
    [JsonPropertyName("company_name")]
    public required string CompanyName { get; init; }

    public class CompanyServices
    {

    }
}

