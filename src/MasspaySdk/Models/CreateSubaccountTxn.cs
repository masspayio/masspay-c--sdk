
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
public class CreateSubaccountTxn
{
    [JsonPropertyName("company_name")]
    [Newtonsoft.Json.JsonProperty("company_name", Required = Newtonsoft.Json.Required.Always)]
    public required string CompanyName { get; init; }
    [JsonPropertyName("company_dba")]
    [Newtonsoft.Json.JsonProperty("company_dba", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string CompanyDba { get; set; }
    [JsonPropertyName("phone")]
    [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.Always)]
    public required string Phone { get; init; }
    [JsonPropertyName("inc_date")]
    [Newtonsoft.Json.JsonProperty("inc_date", Required = Newtonsoft.Json.Required.Always)]
    public required string IncDate { get; init; }
    [JsonPropertyName("registration_number")]
    [Newtonsoft.Json.JsonProperty("registration_number", Required = Newtonsoft.Json.Required.Always)]
    public required string RegistrationNumber { get; init; }
    [JsonPropertyName("website")]
    [Newtonsoft.Json.JsonProperty("website", Required = Newtonsoft.Json.Required.Always)]
    public required string Website { get; init; }
    [JsonPropertyName("naics")]
    [Newtonsoft.Json.JsonProperty("naics", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string Naics { get; set; }
    [JsonPropertyName("min_payee_age")]
    [Newtonsoft.Json.JsonProperty("min_payee_age", Required = Newtonsoft.Json.Required.DisallowNull)]
    public int MinPayeeAge { get; set; }
    [JsonPropertyName("legal_structure")]
    [Newtonsoft.Json.JsonProperty("legal_structure", Required = Newtonsoft.Json.Required.Always)]
    public required CreateSubaccountTxnLegalStructure LegalStructure { get; init; }
    [JsonPropertyName("address1")]
    [Newtonsoft.Json.JsonProperty("address1", Required = Newtonsoft.Json.Required.Always)]
    public required string Address1 { get; init; }
    [JsonPropertyName("address2")]
    [Newtonsoft.Json.JsonProperty("address2", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string Address2 { get; set; }
    [JsonPropertyName("state")]
    [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Always)]
    public required string State { get; init; }
    [JsonPropertyName("city")]
    [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Always)]
    public required string City { get; init; }
    [JsonPropertyName("zip")]
    [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Always)]
    public required string Zip { get; init; }
    [JsonPropertyName("country")]
    [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Always)]
    public required string Country { get; init; }
    [JsonPropertyName("signer")]
    [Newtonsoft.Json.JsonProperty("signer", Required = Newtonsoft.Json.Required.DisallowNull)]
    public CreateSubaccountTxnSigner Signer { get; set; }
    [JsonPropertyName("industry")]
    [Newtonsoft.Json.JsonProperty("industry", Required = Newtonsoft.Json.Required.Always)]
    public required CreateSubaccountTxnIndustry Industry { get; init; }
    /**
     * Legal structure of the corporation
     */
    [JsonConverter(typeof(StringValueEnumConverter<CreateSubaccountTxnLegalStructure>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSubaccountTxnLegalStructure
    {
        [StringValue("Ccorp")]
        CCORP,
        [StringValue("LLC")]
        LLC,
        [StringValue("Partnership")]
        PARTNERSHIP,
        [StringValue("Nonprofit")]
        NONPROFIT,
        [StringValue("Scorp")]
        SCORP,
        [StringValue("Soleprop")]
        SOLEPROP,
        [StringValue("Other")]
        OTHER
    }/**
     * Signer on the account
     */
    public class CreateSubaccountTxnSigner
    {
        [JsonPropertyName("first_name")]
        [Newtonsoft.Json.JsonProperty("first_name", Required = Newtonsoft.Json.Required.Always)]
        public required string FirstName { get; init; }
        [JsonPropertyName("last_name")]
        [Newtonsoft.Json.JsonProperty("last_name", Required = Newtonsoft.Json.Required.Always)]
        public required string LastName { get; init; }
        [JsonPropertyName("email")]
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Always)]
        public required string Email { get; init; }
        [JsonPropertyName("dob")]
        [Newtonsoft.Json.JsonProperty("dob", Required = Newtonsoft.Json.Required.Always)]
        public required string Dob { get; init; }
    }
    /**
     * What industry does the corporation operate in
     */
    [JsonConverter(typeof(StringValueEnumConverter<CreateSubaccountTxnIndustry>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSubaccountTxnIndustry
    {
        [StringValue("MLM")]
        MLM,
        [StringValue("Crypto")]
        CRYPTO,
        [StringValue("Adult")]
        ADULT,
        [StringValue("General")]
        GENERAL
    }
}

