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

public class KycServiceTests
{
    [Fact]
    public async Task KycService_FindAttributesVelocity()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new List<string>
{
    "usr_37ec3232-bda3-4aed-9e79-c03b2373fa3b"

};

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/attribute/{user_token}/velocity");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "");

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
        var service = new KycService(mockedHttpRequest);

        var result = await service.FindAttributesVelocity("", "", new() { new() { Type = 0, Value = "" } });

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task KycService_GetUserUserTokenKycAu10Tix()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            session_url = ""
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/user/{user_token}/kyc/au10tix");

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
        var service = new KycService(mockedHttpRequest);

        var result = await service.GetUserUserTokenKycAu10Tix("");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task KycService_UploadIdPhotos()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/user/{user_token}/kyc/id");

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
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize((new object() { })), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new KycService(mockedHttpRequest);

        var result = await service.UploadIdPhotos("", new List<IdUpload>() { new() { Type = 0, Content = "" } });

        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task KycService_GetUserUserTokenKycAttempts()
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
        provider = "Veriff",
        session_id = "20ea33e3-fb0c-4387-944d-511bd605b0d5",
        session_time = "",
        status = "Started",
        resp = new object()
    }

};

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/user/{user_token}/kyc/id");

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
        var service = new KycService(mockedHttpRequest);

        var result = await service.GetUserUserTokenKycAttempts("");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task KycService_GetUserUserTokenKycVeriff()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            session_url = ""
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/user/{user_token}/kyc/veriff");

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
        var service = new KycService(mockedHttpRequest);

        var result = await service.GetUserUserTokenKycVeriff("");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

}
