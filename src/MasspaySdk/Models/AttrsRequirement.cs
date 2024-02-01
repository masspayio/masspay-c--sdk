
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
public class AttrsRequirement
{
    [JsonPropertyName("token")]
    public required string Token { get; init; }
    [JsonPropertyName("attr_set_token")]
    public string? AttrSetToken { get; set; }
    [JsonPropertyName("label")]
    public string? Label { get; set; }
    [JsonPropertyName("validation")]
    public string? Validation { get; set; }
    [JsonPropertyName("is_optional")]
    public bool? IsOptional { get; set; }
    [JsonPropertyName("value")]
    public required string Value { get; init; }
    [JsonPropertyName("expected_value")]
    public string? ExpectedValue { get; set; }
    [JsonPropertyName("type")]
    public AttrsRequirementType? Type { get; set; }
    [JsonPropertyName("input_type")]
    public required AttrsRequirementInputType InputType { get; init; }
    [JsonPropertyName("last_attr_value_used")]
    public bool? LastAttrValueUsed { get; set; }

    /**
     * The type of attribute
     */
    [JsonConverter(typeof(StringValueEnumConverter<AttrsRequirementType>))]
    public enum AttrsRequirementType
    {
        [StringValue("CardNumber")]
        CARD_NUMBER,
        [StringValue("BankAccountType")]
        BANK_ACCOUNT_TYPE,
        [StringValue("BankAccountNumber")]
        BANK_ACCOUNT_NUMBER,
        [StringValue("BankAccountBranchNumber")]
        BANK_ACCOUNT_BRANCH_NUMBER,
        [StringValue("BankName")]
        BANK_NAME,
        [StringValue("PhoneNumber")]
        PHONE_NUMBER,
        [StringValue("Gender")]
        GENDER,
        [StringValue("IdentificationNumber")]
        IDENTIFICATION_NUMBER,
        [StringValue("BillReferenceNumber")]
        BILL_REFERENCE_NUMBER,
        [StringValue("BankRoutingNumber")]
        BANK_ROUTING_NUMBER,
        [StringValue("BankAccountName")]
        BANK_ACCOUNT_NAME,
        [StringValue("MaidenName")]
        MAIDEN_NAME,
        [StringValue("SocialSecurity")]
        SOCIAL_SECURITY,
        [StringValue("EmploymentName")]
        EMPLOYMENT_NAME,
        [StringValue("EmploymentAddress")]
        EMPLOYMENT_ADDRESS,
        [StringValue("EmploymentPhone")]
        EMPLOYMENT_PHONE,
        [StringValue("EmploymentOccupation")]
        EMPLOYMENT_OCCUPATION,
        [StringValue("EmploymentSupervisor")]
        EMPLOYMENT_SUPERVISOR,
        [StringValue("RemittanceReason")]
        REMITTANCE_REASON,
        [StringValue("Relationship")]
        RELATIONSHIP,
        [StringValue("SecondLastName")]
        SECOND_LAST_NAME,
        [StringValue("SWIFT")]
        SWIFT,
        [StringValue("BirthCountry")]
        BIRTH_COUNTRY,
        [StringValue("SourceOfFunds")]
        SOURCE_OF_FUNDS,
        [StringValue("DateOfBirth")]
        DATE_OF_BIRTH,
        [StringValue("CardExpiration")]
        CARD_EXPIRATION,
        [StringValue("CardZip")]
        CARD_ZIP,
        [StringValue("IdentificationType")]
        IDENTIFICATION_TYPE,
        [StringValue("BankCity")]
        BANK_CITY,
        [StringValue("BankState")]
        BANK_STATE,
        [StringValue("IDSelfieCollection")]
        IDSELFIE_COLLECTION,
        [StringValue("City")]
        CITY,
        [StringValue("Country")]
        COUNTRY,
        [StringValue("IdentificationExpiration")]
        IDENTIFICATION_EXPIRATION,
        [StringValue("Address1")]
        ADDRESS1,
        [StringValue("IFramePaymentCollection")]
        IFRAME_PAYMENT_COLLECTION,
        [StringValue("PostalCode")]
        POSTAL_CODE
    }
    /**
     * The type of input field that is suggested for this this attribute
     */
    [JsonConverter(typeof(StringValueEnumConverter<AttrsRequirementInputType>))]
    public enum AttrsRequirementInputType
    {
        [StringValue("text")]
        TEXT,
        [StringValue("options")]
        OPTIONS,
        [StringValue("date")]
        DATE
    }
}

