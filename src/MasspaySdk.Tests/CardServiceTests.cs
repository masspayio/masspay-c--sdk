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
            expiration_date = "qCRI1Px4",
            pin_number = "1234",
            balance = 103,
            type = "VISA",
            status = "ACTIVE"
        };
        var url = config.BaseUrl + "/wallet/{user_token}/{wallet_token}/card";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "usr_62727c1f-38a3-4a98-b7c9-e84093a106cd");
        parameters.Add("wallet_token", "123e4567-e89b-12d3-a456-426614174000");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new CardService(mockedHttpRequest);

        var result = await service.GetWalletCardInfo("usr_62727c1f-38a3-4a98-b7c9-e84093a106cd", "123e4567-e89b-12d3-a456-426614174000");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task CardService_UpdateWalletCardInfo()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var url = config.BaseUrl + "/wallet/{user_token}/{wallet_token}/card";

        var query = new Dictionary<string, object>();
        query.Add("pin", "0123");
        query.Add("status", "SUSPEND");

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

        await service.UpdateWalletCardInfo("usr_62727c1f-38a3-4a98-b7c9-e84093a106cd", "123e4567-e89b-12d3-a456-426614174000", "0123", 0);
    }

}
