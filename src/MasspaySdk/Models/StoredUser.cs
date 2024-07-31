
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
public class StoredUser
{
    [JsonPropertyName("user_token")]
    [Newtonsoft.Json.JsonProperty("user_token", Required = Newtonsoft.Json.Required.Always)]
    public required string UserToken { get; init; }
    [JsonPropertyName("status")]
    [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
    public required StoredUserStatus Status { get; init; }
    [JsonPropertyName("created_on")]
    [Newtonsoft.Json.JsonProperty("created_on", Required = Newtonsoft.Json.Required.Always)]
    public required string CreatedOn { get; init; }
    [JsonPropertyName("internal_user_id")]
    [Newtonsoft.Json.JsonProperty("internal_user_id", Required = Newtonsoft.Json.Required.Always)]
    public required string InternalUserId { get; init; }
    [JsonPropertyName("address1")]
    [Newtonsoft.Json.JsonProperty("address1", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string Address1 { get; set; }
    [JsonPropertyName("address2")]
    [Newtonsoft.Json.JsonProperty("address2", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string Address2 { get; set; }
    [JsonPropertyName("city")]
    [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string City { get; set; }
    [JsonPropertyName("state_province")]
    [Newtonsoft.Json.JsonProperty("state_province", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string StateProvince { get; set; }
    [JsonPropertyName("postal_code")]
    [Newtonsoft.Json.JsonProperty("postal_code", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string PostalCode { get; set; }
    [JsonPropertyName("country")]
    [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string Country { get; set; }
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
    [JsonPropertyName("language")]
    [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string Language { get; set; }
    [JsonPropertyName("mobile_number")]
    [Newtonsoft.Json.JsonProperty("mobile_number", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string MobileNumber { get; set; }
    [JsonPropertyName("business_name")]
    [Newtonsoft.Json.JsonProperty("business_name", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string BusinessName { get; set; }
    [JsonPropertyName("timezone")]
    [Newtonsoft.Json.JsonProperty("timezone", Required = Newtonsoft.Json.Required.Always)]
    public required string Timezone { get; init; }
    [JsonPropertyName("date_of_birth")]
    [Newtonsoft.Json.JsonProperty("date_of_birth", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string DateOfBirth { get; set; }
    [JsonPropertyName("metadata")]
    [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.DisallowNull)]
    public IDictionary<string, object> Metadata { get; set; }
    [JsonPropertyName("activation_url")]
    [Newtonsoft.Json.JsonProperty("activation_url", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string ActivationUrl { get; set; }
    /**
     * The status of the user
     */
    [JsonConverter(typeof(StringValueEnumConverter<StoredUserStatus>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StoredUserStatus
    {
        [StringValue("ACTIVE")]
        ACTIVE,
        [StringValue("LOCKED")]
        LOCKED,
        [StringValue("DEACTIVE")]
        DEACTIVE
    }
}

