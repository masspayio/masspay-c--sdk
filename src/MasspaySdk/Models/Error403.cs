
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
 * Forbidden.
 */
public class Error403
{
    [JsonPropertyName("title")]
    public Error403Title? Title { get; set; }
    [JsonPropertyName("message")]
    public required Error403Message Message { get; init; }
    [JsonPropertyName("code")]
    public required Error403Code Code { get; init; }

    /**
     * Error title.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403Title>))]
    public enum Error403Title
    {
        [StringValue("Forbidden.")]
        FORBIDDEN_
    }
    /**
     * Error description.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403Message>))]
    public enum Error403Message
    {
        [StringValue("The requested action is not allowed or the API credentials do not have sufficient permissions. Please ensure that the API credentials used for the request have the necessary permissions to perform the requested action.")]
        THE_REQUESTED_ACTION_IS_NOT_ALLOWED_OR_THE_API_CREDENTIALS_DO_NOT_HAVE_SUFFICIENT_PERMISSIONS_PLEASE_ENSURE_THAT_THE_API_CREDENTIALS_USED_FOR_THE_REQUEST_HAVE_THE_NECESSARY_PERMISSIONS_TO_PERFORM_THE_REQUESTED_ACTION_
    }
    /**
     * Error code.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403Code>))]
    public enum Error403Code
    {
        [StringValue("403")]
        _403
    }
}

