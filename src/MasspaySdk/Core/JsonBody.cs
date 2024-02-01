/**
 * MassPay API
 *
 * The version of the OpenAPI document: 0.1.4
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net.Mime;
using System.Text;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace MasspaySdk.Core;

public class JsonBody : IRequestBody
{
    private readonly object _body;

    public JsonBody(object body)
    {
        _body = body;
    }

    public HttpContent GetHttpContent()
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;

        return new StringContent(
          JsonSerializer.Serialize(
            _body,
            options
          ),
          Encoding.UTF8,
          MediaTypeNames.Application.Json
        );
    }
}
