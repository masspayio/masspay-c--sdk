/**
 * MassPay API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text;
using System.Text.Json;
using System.Net;
using MasspaySdk.Core;
using MasspaySdk.Models;
using MasspaySdk.Services;
using RichardSzalay.MockHttp;

namespace MasspaySdk.Tests;

public class AttributeServiceTests
{
    [Fact]
    public async Task AttributeService_GetAllAttrs()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new List<object>
{
    new
    {
        destination_token = "123e4567-e89b-12d3-a456-426614174000",
        payer_logo = "U3dhZ2dlciByb2Nrcw==",
        payer_name = "Elektra",
        exchange_rate = new List<object>(),
        max_limit = 10000,
        min_limit = 0,
        number_of_locations = 13007,
        estimated_availability = "",
        additional_description = "Requires drivers license to pickup funds",
        is_dynamic_token = true,
        attributes = new List<object>()
    }

};

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/attribute/{user_token}");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var responseHeaders = new Dictionary<string, string> {
           { "Access-Control-Allow-Origin","" },
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize(expectedResponse), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new AttributeService(mockedHttpRequest);

        var result = await service.GetAllAttrs("");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task AttributeService_StoreAttrs()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            attr_set_token = ""
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/attribute/{user_token}/{destination_token}/{currency}");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "");
        parameters.Add("destination_token", "");
        parameters.Add("currency", "BRL");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "");

        var responseHeaders = new Dictionary<string, string> {
           { "Access-Control-Allow-Origin","" },
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize(expectedResponse), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new AttributeService(mockedHttpRequest);

        var result = await service.StoreAttrs("", "", "BRL", new() { Values = null, AttrSetToken = "attr_set_e2ca24e9-c546-4c64-90d2-cb8e70e7c9ba" }, "");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task AttributeService_GetAttrs()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new List<object>
{
    new
    {
        token = "attr_e2ca24e9-c546-4c64-90d2-cb8e70e7c9ba",
        attr_set_token = "attr_set_e2ca24e9-c546-4c64-90d2-cb8e70e7c9ba",
        label = "Checking Account Number",
        validation = "[0-9]{50}",
        is_optional = true,
        value = "432532532",
        expected_value = "Date format MM/DD/YYYY",
        type = "BankAccountNumber",
        input_type = "text",
        last_attr_value_used = true
    }

};

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/attribute/{user_token}/{destination_token}/{currency}");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "");
        parameters.Add("destination_token", "");
        parameters.Add("currency", "BRL");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "");

        var responseHeaders = new Dictionary<string, string> {
           { "Access-Control-Allow-Origin","" },
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize(expectedResponse), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new AttributeService(mockedHttpRequest);

        var result = await service.GetAttrs("", "", "BRL", "");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

}
