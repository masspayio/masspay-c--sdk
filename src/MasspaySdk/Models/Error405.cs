
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
 * Method not allowed.
 */
public class Error405
{
    [JsonPropertyName("title")]
    [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull)]
    public Error405Title Title { get; set; }
    [JsonPropertyName("message")]
    [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
    public required Error405Message Message { get; init; }
    [JsonPropertyName("code")]
    [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
    public required Error405Code Code { get; init; }
    /**
     * Error title.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error405Title>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error405Title
    {
        [StringValue("Method not allowed.")]
        METHOD_NOT_ALLOWED_
    }
    /**
     * Error description.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error405Message>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error405Message
    {
        [StringValue("The HTTP method used for the request is not supported by the MassPay API. Please ensure that you are using the correct HTTP method (e.g., POST) for the specific MassPay API endpoint.")]
        THE_HTTP_METHOD_USED_FOR_THE_REQUEST_IS_NOT_SUPPORTED_BY_THE_MASS_PAY_API_PLEASE_ENSURE_THAT_YOU_ARE_USING_THE_CORRECT_HTTP_METHOD_E_G_POST_FOR_THE_SPECIFIC_MASS_PAY_API_ENDPOINT_
    }
    /**
     * Error code.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error405Code>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error405Code
    {
        [StringValue("405")]
        _405
    }
}

