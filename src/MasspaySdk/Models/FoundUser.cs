
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
 * Response object when a user is found
 */
public class FoundUser
{
    [JsonPropertyName("user_token")]
    [Newtonsoft.Json.JsonProperty("user_token", Required = Newtonsoft.Json.Required.Always)]
    public required string UserToken { get; init; }
    [JsonPropertyName("first_name")]
    [Newtonsoft.Json.JsonProperty("first_name", Required = Newtonsoft.Json.Required.Always)]
    public required string FirstName { get; init; }
    [JsonPropertyName("last_name")]
    [Newtonsoft.Json.JsonProperty("last_name", Required = Newtonsoft.Json.Required.Always)]
    public required string LastName { get; init; }
    [JsonPropertyName("internal_user_id")]
    [Newtonsoft.Json.JsonProperty("internal_user_id", Required = Newtonsoft.Json.Required.Always)]
    public required string InternalUserId { get; init; }
}

