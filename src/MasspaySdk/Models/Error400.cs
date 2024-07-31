
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
 * Bad request.
 */
public class Error400
{
    [JsonPropertyName("title")]
    [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull)]
    public Error400Title Title { get; set; }
    [JsonPropertyName("message")]
    [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
    public required Error400Message Message { get; init; }
    [JsonPropertyName("code")]
    [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
    public required Error400Code Code { get; init; }
    [JsonPropertyName("error")]
    [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.DisallowNull)]
    public Error400Error Error { get; set; }
    /**
     * Error title.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400Title>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error400Title
    {
        [StringValue("Bad request.")]
        BAD_REQUEST_
    }
    /**
     * Error description.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400Message>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error400Message
    {
        [StringValue("The request was invalid or malformed. Please ensure that the request body conforms to the required format and that all required parameters are included.")]
        THE_REQUEST_WAS_INVALID_OR_MALFORMED_PLEASE_ENSURE_THAT_THE_REQUEST_BODY_CONFORMS_TO_THE_REQUIRED_FORMAT_AND_THAT_ALL_REQUIRED_PARAMETERS_ARE_INCLUDED_
    }
    /**
     * Error code.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400Code>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error400Code
    {
        [StringValue("400")]
        _400
    }
    public class Error400Error
    {
        [JsonPropertyName("reason")]
        [Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.DisallowNull)]
        public string Reason { get; set; }
        [JsonPropertyName("details")]
        [Newtonsoft.Json.JsonProperty("details", Required = Newtonsoft.Json.Required.DisallowNull)]
        public IEnumerable<string> Details { get; set; }
    }
}

