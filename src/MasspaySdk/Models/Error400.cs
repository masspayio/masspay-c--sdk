
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
 * Bad request.
 */
public class Error400
{
    [JsonPropertyName("title")]
    public Error400Title? Title { get; set; }
    [JsonPropertyName("message")]
    public required Error400Message Message { get; init; }
    [JsonPropertyName("code")]
    public required Error400Code Code { get; init; }

    /**
     * Error title.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400Title>))]
    public enum Error400Title
    {
        [StringValue("Bad request.")]
        BAD_REQUEST_
    }
    /**
     * Error description.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400Message>))]
    public enum Error400Message
    {
        [StringValue("The request was invalid or malformed. Please ensure that the request body conforms to the required format and that all required parameters are included.")]
        THE_REQUEST_WAS_INVALID_OR_MALFORMED_PLEASE_ENSURE_THAT_THE_REQUEST_BODY_CONFORMS_TO_THE_REQUIRED_FORMAT_AND_THAT_ALL_REQUIRED_PARAMETERS_ARE_INCLUDED_
    }
    /**
     * Error code.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400Code>))]
    public enum Error400Code
    {
        [StringValue("400")]
        _400
    }
}

