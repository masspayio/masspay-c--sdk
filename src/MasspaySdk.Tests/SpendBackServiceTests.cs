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

public class SpendBackServiceTests
{
    [Fact]
    public async Task SpendBackService_GetUserSpendbacksByToken()
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
    spendback_token = "spnd_bk_4275f2-bae1-488d-9d6f-20af1cd83574",
    time_of_spendback = "2019-07-07T23:03:05",
    client_spendback_id = "aEjn345",
    source_token = "123e4567-e89b-12d3-a456-426614174000",
    wallet_token = "123e4567-e89b-12d3-a456-426614174000",
    amount = 100.5,
    source_currency_code = "USD",
    notes = "Commission payment for July",
    metadata = default(object)
}
};
        var url = config.BaseUrl + "/spendback/{user_token}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "usr_3f5d3fe8-a9c0-48c7-90ad-a72948730f56");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "92qdtxXCrS");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new SpendBackService(mockedHttpRequest);

        var result = await service.GetUserSpendbacksByToken("usr_3f5d3fe8-a9c0-48c7-90ad-a72948730f56", "92qdtxXCrS");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task SpendBackService_InitiateSpendback()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            spendback_token = "123e4567-e89b-12d3-a456-426614174000",
            client_spendback_id = "aEjn345",
            status = "success"
        };
        var url = config.BaseUrl + "/spendback/{user_token}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "usr_3f5d3fe8-a9c0-48c7-90ad-a72948730f56");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "k5sNCLCC");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new SpendBackService(mockedHttpRequest);

        var result = await service.InitiateSpendback("usr_3f5d3fe8-a9c0-48c7-90ad-a72948730f56", "k5sNCLCC", new() { ClientSpendbackId = "aEjn345", SourceToken = "123e4567-e89b-12d3-a456-426614174000", SourceCurrencyCode = "USD", Amount = 100.5, Notes = "Purchase of Candles. Order #14930", Metadata = null });

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

}
