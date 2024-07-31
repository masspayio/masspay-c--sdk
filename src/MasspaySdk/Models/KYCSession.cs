
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
public class KycSession
{
    [JsonPropertyName("provider")]
    [Newtonsoft.Json.JsonProperty("provider", Required = Newtonsoft.Json.Required.Always)]
    public required KycSessionProvider Provider { get; init; }
    [JsonPropertyName("session_id")]
    [Newtonsoft.Json.JsonProperty("session_id", Required = Newtonsoft.Json.Required.Always)]
    public required string SessionId { get; init; }
    [JsonPropertyName("session_time")]
    [Newtonsoft.Json.JsonProperty("session_time", Required = Newtonsoft.Json.Required.Always)]
    public required string SessionTime { get; init; }
    [JsonPropertyName("status")]
    [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
    public required KycSessionStatus Status { get; init; }
    [JsonPropertyName("resp")]
    [Newtonsoft.Json.JsonProperty("resp", Required = Newtonsoft.Json.Required.DisallowNull)]
    public IDictionary<string, object> Resp { get; set; }
    [JsonConverter(typeof(StringValueEnumConverter<KycSessionProvider>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum KycSessionProvider
    {
        [StringValue("Veriff")]
        VERIFF,
        [StringValue("Au10tix")]
        AU10TIX
    }
    [JsonConverter(typeof(StringValueEnumConverter<KycSessionStatus>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum KycSessionStatus
    {
        [StringValue("Started")]
        STARTED,
        [StringValue("Submitted")]
        SUBMITTED,
        [StringValue("Abandoned")]
        ABANDONED,
        [StringValue("Expired")]
        EXPIRED,
        [StringValue("Resubmitted")]
        RESUBMITTED,
        [StringValue("Declined")]
        DECLINED,
        [StringValue("Approved")]
        APPROVED,
        [StringValue("Resubmission requested")]
        RESUBMISSION_REQUESTED,
        [StringValue("Review")]
        REVIEW
    }
}

