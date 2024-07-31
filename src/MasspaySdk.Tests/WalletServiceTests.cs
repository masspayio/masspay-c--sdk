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

public class WalletServiceTests
{
    [Fact]
    public async Task WalletService_GetWallet()
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
        user_token = "usr_ba4275f2-bae1-488d-9d6f-20af1cd83574",
        token = "123e4567-e89b-12d3-a456-426614174000",
        balance = 100.5,
        currency_code = "USD",
        type = "USER_FUNDS",
        card_type = "VISA",
        last_4 = "1234",
        active = true,
        client_paying_fees = true
    }

};

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/wallet/{user_token}");

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
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize(expectedResponse), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new WalletService(mockedHttpRequest);

        var result = await service.GetWallet("", "");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task WalletService_GetAutopayoutRules()
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
        token = "autopayout_3684cc43-fe3b-4994-8ca1-7dc0db94430f",
        destination_token = "dest_d2138fd0-00be-45a8-985f-4f5bde500962",
        percentage = 50,
        attr_set_token = ""
    }

};

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/wallet/{user_token}/{wallet_token}/autopayout");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "");
        parameters.Add("wallet_token", "");

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
        var service = new WalletService(mockedHttpRequest);

        var result = await service.GetAutopayoutRules("", "");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task WalletService_CreateAutopayoutRule()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            token = "autopayout_3684cc43-fe3b-4994-8ca1-7dc0db94430f",
            destination_token = "dest_d2138fd0-00be-45a8-985f-4f5bde500962",
            percentage = 50,
            attr_set_token = ""
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/wallet/{user_token}/{wallet_token}/autopayout");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "");
        parameters.Add("wallet_token", "");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var responseHeaders = new Dictionary<string, string> {
           { "Access-Control-Allow-Origin","" },
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize(expectedResponse), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new WalletService(mockedHttpRequest);

        var result = await service.CreateAutopayoutRule("", "", new() { DestinationToken = "dest_d2138fd0-00be-45a8-985f-4f5bde500962", Percentage = 50, AttrSetToken = "" });

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task WalletService_DeleteAutopayoutRule()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/wallet/{user_token}/{wallet_token}/autopayout");

        var query = new Dictionary<string, object>();
        query.Add("token", "autopayout_3684cc43-fe3b-4994-8ca1-7dc0db94430f");

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "");
        parameters.Add("wallet_token", "");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };


        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Delete, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(new object() { }));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new WalletService(mockedHttpRequest);

        var result = await service.DeleteAutopayoutRule("", "", "autopayout_3684cc43-fe3b-4994-8ca1-7dc0db94430f");

    }

}
