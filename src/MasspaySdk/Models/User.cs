
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
public class User
{
    [JsonPropertyName("internal_user_id")]
    public required string InternalUserId { get; init; }
    [JsonPropertyName("address1")]
    public string? Address1 { get; set; }
    [JsonPropertyName("address2")]
    public string? Address2 { get; set; }
    [JsonPropertyName("city")]
    public string? City { get; set; }
    [JsonPropertyName("state_province")]
    public string? StateProvince { get; set; }
    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; set; }
    [JsonPropertyName("country")]
    public required string Country { get; init; }
    [JsonPropertyName("first_name")]
    public required string FirstName { get; init; }
    [JsonPropertyName("middle_name")]
    public string? MiddleName { get; set; }
    [JsonPropertyName("last_name")]
    public required string LastName { get; init; }
    [JsonPropertyName("email")]
    public required string Email { get; init; }
    [JsonPropertyName("language")]
    public string? Language { get; set; }
    [JsonPropertyName("mobile_number")]
    public string? MobileNumber { get; set; }
    [JsonPropertyName("business_name")]
    public string? BusinessName { get; set; }
    [JsonPropertyName("date_of_birth")]
    public string? DateOfBirth { get; set; }
    [JsonPropertyName("metadata")]
    public UserMetadata? Metadata { get; set; }
    [JsonPropertyName("notify_user")]
    public bool? NotifyUser { get; set; }

    /**
     * Optional JSON object with attributes that can later be searched to locate this user. Do not include PII as this object is not encrypted.
     */
    public class UserMetadata
    {
        [JsonPropertyName("group_id")]
        public double? GroupId { get; set; }

    }
}

