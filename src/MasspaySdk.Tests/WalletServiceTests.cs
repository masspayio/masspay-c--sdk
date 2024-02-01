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
    type = "MASSPAY_CARD",
    card_type = "MASTERCARD",
    last_4 = "1234",
    active = true,
    client_paying_fees = true
}
};
        var url = config.BaseUrl + "/wallet/{user_token}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "X0e0");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "6Cng2wr1");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new WalletService(mockedHttpRequest);

        var result = await service.GetWallet("X0e0", "6Cng2wr1");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task WalletService_GetAutopayRules()
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
    token = "autopay_3684cc43-fe3b-4994-8ca1-7dc0db94430f",
    destination_token = "dest_d2138fd0-00be-45a8-985f-4f5bde500962",
    percentage = 50
}
};
        var url = config.BaseUrl + "/wallet/{user_token}/{wallet_token}/autopay";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "DSGO7O");
        parameters.Add("wallet_token", "51ecLas2D");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new WalletService(mockedHttpRequest);

        var result = await service.GetAutopayRules("DSGO7O", "51ecLas2D");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task WalletService_CreateAutopayRule()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            token = "autopay_3684cc43-fe3b-4994-8ca1-7dc0db94430f",
            destination_token = "dest_d2138fd0-00be-45a8-985f-4f5bde500962",
            percentage = 50
        };
        var url = config.BaseUrl + "/wallet/{user_token}/{wallet_token}/autopay";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "DSGO7O");
        parameters.Add("wallet_token", "51ecLas2D");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new WalletService(mockedHttpRequest);

        var result = await service.CreateAutopayRule("DSGO7O", "51ecLas2D", new() { DestinationToken = "dest_d2138fd0-00be-45a8-985f-4f5bde500962", Percentage = 50 });

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task WalletService_DeleteAutopayRule()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var url = config.BaseUrl + "/wallet/{user_token}/{wallet_token}/autopay";

        var query = new Dictionary<string, object>();
        query.Add("token", "autopay_3684cc43-fe3b-4994-8ca1-7dc0db94430f");

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "DSGO7O");
        parameters.Add("wallet_token", "51ecLas2D");

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

        await service.DeleteAutopayRule("DSGO7O", "51ecLas2D", "autopay_3684cc43-fe3b-4994-8ca1-7dc0db94430f");
    }

}
