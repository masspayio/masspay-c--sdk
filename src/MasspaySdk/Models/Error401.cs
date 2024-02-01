
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
/**
 * Unauthorized.
 */
public class Error401
{
    [JsonPropertyName("title")]
    public Error401Title? Title { get; set; }
    [JsonPropertyName("message")]
    public required Error401Message Message { get; init; }
    [JsonPropertyName("code")]
    public required Error401Code Code { get; init; }

    /**
     * Error title.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error401Title>))]
    public enum Error401Title
    {
        [StringValue("Unauthorized.")]
        UNAUTHORIZED_
    }
    /**
     * Error description.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error401Message>))]
    public enum Error401Message
    {
        [StringValue("Authentication failed or credentials were not provided. Please ensure that you have provided valid API credentials and that they are authorized to access the MassPay API.")]
        AUTHENTICATION_FAILED_OR_CREDENTIALS_WERE_NOT_PROVIDED_PLEASE_ENSURE_THAT_YOU_HAVE_PROVIDED_VALID_API_CREDENTIALS_AND_THAT_THEY_ARE_AUTHORIZED_TO_ACCESS_THE_MASS_PAY_API_
    }
    /**
     * Error code.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error401Code>))]
    public enum Error401Code
    {
        [StringValue("401")]
        _401
    }
}

