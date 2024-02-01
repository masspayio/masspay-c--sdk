
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
 * Internal server error
 */
public class Error500
{
    [JsonPropertyName("title")]
    public Error500Title? Title { get; set; }
    [JsonPropertyName("message")]
    public required Error500Message Message { get; init; }
    [JsonPropertyName("code")]
    public required Error500Code Code { get; init; }

    /**
     * Error title.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500Title>))]
    public enum Error500Title
    {
        [StringValue("Internal server error.")]
        INTERNAL_SERVER_ERROR_
    }
    /**
     * Error description.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500Message>))]
    public enum Error500Message
    {
        [StringValue("An unexpected error occurred on the server-side while processing the request. Please try again later or contact support if the issue persists.")]
        AN_UNEXPECTED_ERROR_OCCURRED_ON_THE_SERVER_SIDE_WHILE_PROCESSING_THE_REQUEST_PLEASE_TRY_AGAIN_LATER_OR_CONTACT_SUPPORT_IF_THE_ISSUE_PERSISTS_
    }
    /**
     * Error code.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500Code>))]
    public enum Error500Code
    {
        [StringValue("500")]
        _500
    }
}

