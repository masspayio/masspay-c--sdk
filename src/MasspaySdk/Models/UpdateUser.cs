
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
public class UpdateUser
{
    [JsonPropertyName("status")]
    public required UpdateUserStatus Status { get; init; }
    [JsonPropertyName("created_on")]
    public string? CreatedOn { get; set; }
    [JsonPropertyName("internal_user_id")]
    public required string InternalUserId { get; init; }
    [JsonPropertyName("address1")]
    public required string Address1 { get; init; }
    [JsonPropertyName("address2")]
    public string? Address2 { get; set; }
    [JsonPropertyName("city")]
    public required string City { get; init; }
    [JsonPropertyName("state_province")]
    public required string StateProvince { get; init; }
    [JsonPropertyName("postal_code")]
    public required string PostalCode { get; init; }
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
    public IDictionary<string, object?>? Metadata { get; set; }

    /**
     * The status of the user, if set to ACTIVE when current status is DEACTIVE, reactivation fee will incur
     */
    [JsonConverter(typeof(StringValueEnumConverter<UpdateUserStatus>))]
    public enum UpdateUserStatus
    {
        [StringValue("ACTIVE")]
        ACTIVE,
        [StringValue("DEACTIVE")]
        DEACTIVE
    }
}

