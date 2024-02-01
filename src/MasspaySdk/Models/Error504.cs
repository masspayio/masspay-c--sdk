
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
 * Gateway Time-out.
 */
public class Error504
{
    [JsonPropertyName("title")]
    public Error504Title? Title { get; set; }
    [JsonPropertyName("message")]
    public required Error504Message Message { get; init; }
    [JsonPropertyName("code")]
    public required Error504Code Code { get; init; }

    /**
     * Error title.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error504Title>))]
    public enum Error504Title
    {
        [StringValue("Gateway Time-out.")]
        GATEWAY_TIME_OUT_
    }
    /**
     * Error description.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error504Message>))]
    public enum Error504Message
    {
        [StringValue("The request timed out while waiting for a response from the server. Please try again later or contact support if the issue persists.")]
        THE_REQUEST_TIMED_OUT_WHILE_WAITING_FOR_A_RESPONSE_FROM_THE_SERVER_PLEASE_TRY_AGAIN_LATER_OR_CONTACT_SUPPORT_IF_THE_ISSUE_PERSISTS_
    }
    /**
     * Error code.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error504Code>))]
    public enum Error504Code
    {
        [StringValue("500")]
        _500
    }
}

