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

public class LoadServiceTests
{
    [Fact]
    public async Task LoadService_ResendBalanceNotification()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            success = true
        };
        var url = config.BaseUrl + "/wallet/{user_token}";

        var query = new Dictionary<string, object>();
        query.Add("wallet_token", "ewZhXjbT");

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "dIufINx");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "ZkeHAym4U");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Put, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new LoadService(mockedHttpRequest);

        var result = await service.ResendBalanceNotification("dIufINx", "ewZhXjbT", "ZkeHAym4U");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task LoadService_LoadUser()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            load_token = "ba4275f2-bae1-488d-9d6f-20af1cd83574",
            status = "COMPLETED"
        };
        var url = config.BaseUrl + "/load/{user_token}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "aLVX");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "RLbVgQCB");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new LoadService(mockedHttpRequest);

        var result = await service.LoadUser("aLVX", new() { ClientLoadId = "aEjn345", SourceToken = "ba4275f2-bae1-488d-9d6f-20af1cd83574", Amount = 100.5, SourceCurrencyCode = "USD", Notes = "Commission payment for July", NotifyUser = true, TimeToProcess = "The date/time to process the load. In UTC. 2021-02-25T23:00:00Z", Metadata = null }, "RLbVgQCB");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task LoadService_GetUserLoadsByToken()
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
    load_token = "ld_ba4275f2-bae1-488d-9d6f-20af1cd83574",
    time_of_load = "2019-07-07T23:03:05",
    client_load_id = "aEjn345",
    source_token = "123e4567-e89b-12d3-a456-426614174000",
    wallet_token = "123e4567-e89b-12d3-a456-426614174000",
    amount = 100.5,
    source_currency_code = "USD",
    notes = "Commission payment for July",
    status = "COMPLETED",
    metadata = default(object)
}
};
        var url = config.BaseUrl + "/load/{user_token}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "0MJeMqSILz");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "7RZ1");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new LoadService(mockedHttpRequest);

        var result = await service.GetUserLoadsByToken("0MJeMqSILz", "7RZ1");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task LoadService_ResendLoadNotification()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            success = true
        };
        var url = config.BaseUrl + "/load/{user_token}";

        var query = new Dictionary<string, object>();
        query.Add("load_token", "zMofuQYVOb");

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "GOeZ");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "7Ya9nWiH");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Put, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new LoadService(mockedHttpRequest);

        var result = await service.ResendLoadNotification("GOeZ", "zMofuQYVOb", "7Ya9nWiH");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task LoadService_CancelUserLoad()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var url = config.BaseUrl + "/load/{user_token}";

        var query = new Dictionary<string, object>();
        query.Add("load_token", "boLp");

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "GOeZ");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "cvCcwTDC");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Delete, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(new object() { }));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new LoadService(mockedHttpRequest);

        await service.CancelUserLoad("GOeZ", "boLp", "cvCcwTDC");
    }

}
