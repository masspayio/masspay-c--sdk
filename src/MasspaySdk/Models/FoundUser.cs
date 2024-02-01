
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
 * Response object when a user is found
 */
public class FoundUser
{
    [JsonPropertyName("user_token")]
    public required string UserToken { get; init; }
    [JsonPropertyName("first_name")]
    public required string FirstName { get; init; }
    [JsonPropertyName("last_name")]
    public required string LastName { get; init; }
    [JsonPropertyName("internal_user_id")]
    public required string InternalUserId { get; init; }

}

