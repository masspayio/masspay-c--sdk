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

public class CardServiceTests
{
    [Fact]
    public async Task CardService_GetWalletCardInfo()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            card_number = "4016483301928344",
            cvv = "123",
            expiration_date = "",
            pin_number = "1234",
            balance = 103,
            type = "VISA",
            status = "ACTIVE"
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/wallet/{user_token}/{wallet_token}/card");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "usr_62727c1f-38a3-4a98-b7c9-e84093a106cd");
        parameters.Add("wallet_token", "123e4567-e89b-12d3-a456-426614174000");

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
        var service = new CardService(mockedHttpRequest);

        var result = await service.GetWalletCardInfo("usr_62727c1f-38a3-4a98-b7c9-e84093a106cd", "123e4567-e89b-12d3-a456-426614174000");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task CardService_UpdateWalletCardInfo()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/wallet/{user_token}/{wallet_token}/card");

        var query = new Dictionary<string, object>();
        query.Add("pin", "0123");
        query.Add("status", "CLOSE");

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "usr_62727c1f-38a3-4a98-b7c9-e84093a106cd");
        parameters.Add("wallet_token", "123e4567-e89b-12d3-a456-426614174000");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };


        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Put, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(new object() { }));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new CardService(mockedHttpRequest);

        var result = await service.UpdateWalletCardInfo("usr_62727c1f-38a3-4a98-b7c9-e84093a106cd", "123e4567-e89b-12d3-a456-426614174000", "0123", CardService.UpdateWalletCardInfoStatus.CLOSE);

    }

}
