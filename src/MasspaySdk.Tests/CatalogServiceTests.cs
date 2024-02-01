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

public class CatalogServiceTests
{
    [Fact]
    public async Task CatalogService_GetCountryList()
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
    code = "MX",
    name = "Mexico",
    three_letter_code = "MEX"
}
};
        var url = config.BaseUrl + "/country/list";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new CatalogService(mockedHttpRequest);

        var result = await service.GetCountryList();

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task CatalogService_GetCountryServices()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            companies = default(object)
        };
        var url = config.BaseUrl + "/country/{country_code}";

        var query = new Dictionary<string, object>();
        query.Add("amount", "200");
        query.Add("limit", 15.545719249173999);
        query.Add("wallet_token", "NSA1u");
        query.Add("include_payer_logos", false);
        query.Add("user_token", "xwb0P8Ifr");
        query.Add("source_currency", "G819zH");
        query.Add("payer_name", "N41i");
        query.Add("destination_currency", "r6EYt3S7");

        var parameters = new Dictionary<string, object>();
        parameters.Add("country_code", "a6YCoDor55");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "8TFW8wop8U");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new CatalogService(mockedHttpRequest);

        var result = await service.GetCountryServices("a6YCoDor55", 15.545719249173999, "NSA1u", "xwb0P8Ifr", "G819zH", "N41i", "r6EYt3S7", "8TFW8wop8U", "200", false);

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task CatalogService_GetCheapestCountryServices()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            companies = default(object)
        };
        var url = config.BaseUrl + "/country/{country_code}/cheapest";

        var query = new Dictionary<string, object>();
        query.Add("amount", "200");
        query.Add("limit", 31.634138248162344);
        query.Add("wallet_token", "kImW6");
        query.Add("include_payer_logos", false);
        query.Add("user_token", "pQ9qEb9Zc");
        query.Add("source_currency", "JVTyW0ejn");
        query.Add("payer_name", "b6xDDXtW");
        query.Add("destination_currency", "bZj1");

        var parameters = new Dictionary<string, object>();
        parameters.Add("country_code", "r8BqFFS");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "SP79");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new CatalogService(mockedHttpRequest);

        var result = await service.GetCheapestCountryServices("r8BqFFS", 31.634138248162344, "kImW6", "pQ9qEb9Zc", "JVTyW0ejn", "b6xDDXtW", "bZj1", "SP79", "200", false);

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task CatalogService_GetDestinationTokenAlternatives()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            country_code = "MEX",
            delivery_type = "CASH_PICKUP",
            payers = default(object)
        };
        var url = config.BaseUrl + "/service/{destination_token}/alternatives";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("destination_token", "2yptVkOX7L");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "QKGrG64A4s");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new CatalogService(mockedHttpRequest);

        var result = await service.GetDestinationTokenAlternatives("2yptVkOX7L", "QKGrG64A4s");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task CatalogService_GetDestinationToken()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            country_code = "MEX",
            delivery_type = "CASH_PICKUP",
            payers = default(object)
        };
        var url = config.BaseUrl + "/service/{destination_token}";

        var query = new Dictionary<string, object>();
        query.Add("include_payer_logos", true);

        var parameters = new Dictionary<string, object>();
        parameters.Add("destination_token", "KCk7sY");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "lu2zuR");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new CatalogService(mockedHttpRequest);

        var result = await service.GetDestinationToken("KCk7sY", true, "lu2zuR");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task CatalogService_GetUserAgreement()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            name = "MassPay Card Program - USD",
            content = "YC1u9",
            last_modified = "2020-07-21T17:32:28Z",
            id = 2,
            mime_type = "application/pdf"
        };
        var url = config.BaseUrl + "/user-agreements";

        var query = new Dictionary<string, object>();
        query.Add("id", 2);

        var parameters = new Dictionary<string, object>();

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new CatalogService(mockedHttpRequest);

        var result = await service.GetUserAgreement(2);

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task CatalogService_GetUserAgreementsNames()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            name = "MassPay Card Program - USD",
            last_modified = "2020-07-21T17:32:28Z",
            id = 2,
            mime_type = "application/pdf"
        };
        var url = config.BaseUrl + "/user-agreements";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Options, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new CatalogService(mockedHttpRequest);

        var result = await service.GetUserAgreementsNames();

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

}
