
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
public class TaxYearUserResp
{
    [JsonPropertyName("user_token")]
    public string? UserToken { get; set; }
    [JsonPropertyName("address1")]
    public required string Address1 { get; init; }
    [JsonPropertyName("address2")]
    public string? Address2 { get; set; }
    [JsonPropertyName("city")]
    public required string City { get; init; }
    [JsonPropertyName("state_province")]
    public string? StateProvince { get; set; }
    [JsonPropertyName("postal_code")]
    public double? PostalCode { get; set; }
    [JsonPropertyName("country")]
    public required string Country { get; init; }
    [JsonPropertyName("first_name")]
    public required string FirstName { get; init; }
    [JsonPropertyName("middle_name")]
    public string? MiddleName { get; set; }
    [JsonPropertyName("last_name")]
    public required string LastName { get; init; }
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    [JsonPropertyName("mobile_number")]
    public string? MobileNumber { get; set; }
    [JsonPropertyName("business_name")]
    public string? BusinessName { get; set; }
    [JsonPropertyName("date_of_birth")]
    public required string DateOfBirth { get; init; }
    [JsonPropertyName("balance")]
    public required double Balance { get; init; }
    [JsonPropertyName("tax_id")]
    public string? TaxId { get; set; }

}

