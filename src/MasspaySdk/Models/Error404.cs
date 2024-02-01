
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
 * Not found.
 */
public class Error404
{
    [JsonPropertyName("title")]
    public Error404Title? Title { get; set; }
    [JsonPropertyName("message")]
    public required Error404Message Message { get; init; }
    [JsonPropertyName("code")]
    public required Error404Code Code { get; init; }

    /**
     * Error title.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404Title>))]
    public enum Error404Title
    {
        [StringValue("Not found.")]
        NOT_FOUND_
    }
    /**
     * Error description.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404Message>))]
    public enum Error404Message
    {
        [StringValue("The requested resource was not found. Please ensure that the URL for the request is correct and that the requested resource exists.")]
        THE_REQUESTED_RESOURCE_WAS_NOT_FOUND_PLEASE_ENSURE_THAT_THE_URL_FOR_THE_REQUEST_IS_CORRECT_AND_THAT_THE_REQUESTED_RESOURCE_EXISTS_
    }
    /**
     * Error code.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404Code>))]
    public enum Error404Code
    {
        [StringValue("404")]
        _404
    }
}

