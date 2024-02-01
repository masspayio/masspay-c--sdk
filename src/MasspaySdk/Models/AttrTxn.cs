
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
public class AttrTxn
{
    [JsonPropertyName("values")]
    public required IEnumerable<AttrValue> Values { get; init; }
    [JsonPropertyName("attr_set_token")]
    public string? AttrSetToken { get; set; }

    public class AttrTxnValues
    {

    }
}

