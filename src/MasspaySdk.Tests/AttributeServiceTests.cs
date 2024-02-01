/**
 * MassPay API
 *
 * The version of the OpenAPI document: 0.1.4
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json;
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
    exchange_rate = default(object),
    max_limit = 10000,
    min_limit = 84.70366090768948,
    number_of_locations = 13007,
    estimated_availability = "2020-07-21T17:32:28Z",
    additional_description = "Requires drivers license to pickup funds",
    is_dynamic_token = true,
    attributes = default(object)
}
};
        var url = config.BaseUrl + "/attribute/{user_token}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "2FwaNF");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new AttributeService(mockedHttpRequest);

        var result = await service.GetAllAttrs("2FwaNF");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
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
            attr_set_token = "qEa6N"
        };
        var url = config.BaseUrl + "/attribute/{user_token}/{destination_token}/{currency}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "Y2FGvDjJ");
        parameters.Add("destination_token", "q0Rm");
        parameters.Add("currency", "BRL");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "gm6OBO1Rbd");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new AttributeService(mockedHttpRequest);

        var result = await service.StoreAttrs("Y2FGvDjJ", "q0Rm", "BRL", new() { Values = null, AttrSetToken = "attr_set_e2ca24e9-c546-4c64-90d2-cb8e70e7c9ba" }, "gm6OBO1Rbd");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
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
    type = "CardNumber",
    input_type = "text",
    last_attr_value_used = true
}
};
        var url = config.BaseUrl + "/attribute/{user_token}/{destination_token}/{currency}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "m8QhsUkr");
        parameters.Add("destination_token", "XrBDU6x7z");
        parameters.Add("currency", "BRL");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "3YldR7yW");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new AttributeService(mockedHttpRequest);

        var result = await service.GetAttrs("m8QhsUkr", "XrBDU6x7z", "BRL", "3YldR7yW");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

}
