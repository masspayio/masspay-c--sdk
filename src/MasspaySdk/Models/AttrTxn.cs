
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
public class AttrTxn
{
    [JsonPropertyName("values")]
    [Newtonsoft.Json.JsonProperty("values", Required = Newtonsoft.Json.Required.Always)]
    public required IEnumerable<AttrValue> Values { get; init; }
    [JsonPropertyName("attr_set_token")]
    [Newtonsoft.Json.JsonProperty("attr_set_token", Required = Newtonsoft.Json.Required.DisallowNull)]
    public string AttrSetToken { get; set; }
    public class AttrTxnValues { }
}

