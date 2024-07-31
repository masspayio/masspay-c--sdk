
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
/**
 * Not found.
 */
public class Error404
{
    [JsonPropertyName("title")]
    [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull)]
    public Error404Title Title { get; set; }
    [JsonPropertyName("message")]
    [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
    public required Error404Message Message { get; init; }
    [JsonPropertyName("code")]
    [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
    public required Error404Code Code { get; init; }
    /**
     * Error title.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404Title>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error404Title
    {
        [StringValue("Not found.")]
        NOT_FOUND_
    }
    /**
     * Error description.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404Message>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error404Message
    {
        [StringValue("The requested resource was not found. Please ensure that the URL for the request is correct and that the requested resource exists.")]
        THE_REQUESTED_RESOURCE_WAS_NOT_FOUND_PLEASE_ENSURE_THAT_THE_URL_FOR_THE_REQUEST_IS_CORRECT_AND_THAT_THE_REQUESTED_RESOURCE_EXISTS_
    }
    /**
     * Error code.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404Code>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error404Code
    {
        [StringValue("404")]
        _404
    }
}

