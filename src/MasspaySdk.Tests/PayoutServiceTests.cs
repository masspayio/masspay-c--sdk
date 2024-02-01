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

public class PayoutServiceTests
{
    [Fact]
    public async Task PayoutService_InitiatePayout()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            payout_token = "ba4275f2-bae1-488d-9d6f-20af1cd83574",
            client_transfer_id = "aEjn345",
            source_currency_code = "USD",
            destination_currency_code = "MXN",
            source_token = "ba4275f2-bae1-488d-9d6f-20af1cd83574",
            destination_token = "d2138fd0-00be-45a8-985f-4f5bde500962",
            destination_amount = 100.5,
            source_amount = 100.5,
            attr_set_token = "b1a867c1-6e36-4525-b6d5-a20bac80e3b0",
            exchange_rate = 18.55,
            fee = 2.99,
            expiration = "2019-06-26T22:32:05",
            pickup_code = "54238173",
            status = "PENDING",
            payer_logo = "U3dhZ2dlciByb2Nrcw==",
            payer_name = "Elektra",
            delivery_type = "CASH_PICKUP",
            country_code = "MEX",
            metadata = default(object),
            estimated_availability = "2020-07-21T17:32:28Z",
            status_reason = "7Vwu",
            attrs = default(object)
        };
        var url = config.BaseUrl + "/payout/{user_token}";

        var query = new Dictionary<string, object>();
        query.Add("limit", 21.102768895216286);

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "86pbi");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "ls3UMzh");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new PayoutService(mockedHttpRequest);

        var result = await service.InitiatePayout("86pbi", new() { ClientTransferId = "aEjn345", SourceCurrencyCode = "USD", DestinationCurrencyCode = "MXN", SourceToken = "123e4567-e89b-12d3-a456-426614174000", DestinationToken = "123e4567-e89b-12d3-a456-426614174000", DestinationAmount = 100.5, SourceAmount = 100.5, AttrSetToken = "123e4567-e89b-12d3-a456-426614174000", Metadata = null, NotifyUser = true }, 21.102768895216286, "ls3UMzh");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task PayoutService_GetUserPayoutsByToken()
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
    payout_token = "ba4275f2-bae1-488d-9d6f-20af1cd83574",
    client_transfer_id = "aEjn345",
    source_currency_code = "USD",
    destination_currency_code = "MXN",
    source_token = "ba4275f2-bae1-488d-9d6f-20af1cd83574",
    destination_token = "d2138fd0-00be-45a8-985f-4f5bde500962",
    destination_amount = 100.5,
    source_amount = 100.5,
    attr_set_token = "b1a867c1-6e36-4525-b6d5-a20bac80e3b0",
    exchange_rate = 18.55,
    fee = 2.99,
    expiration = "2019-06-26T22:32:05",
    pickup_code = "54238173",
    status = "PENDING",
    payer_logo = "U3dhZ2dlciByb2Nrcw==",
    payer_name = "Elektra",
    delivery_type = "CASH_PICKUP",
    country_code = "MEX",
    metadata = default(object),
    estimated_availability = "2020-07-21T17:32:28Z",
    status_reason = "S88Xy6E",
    attrs = default(object)
}
};
        var url = config.BaseUrl + "/payout/{user_token}";

        var query = new Dictionary<string, object>();
        query.Add("include_payer_logos", false);

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "oysXCfY");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "unDPq");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new PayoutService(mockedHttpRequest);

        var result = await service.GetUserPayoutsByToken("oysXCfY", "unDPq", false);

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task PayoutService_CommitPayoutTxn()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            payout_token = "123e4567-e89b-12d3-a456-426614174000",
            status = "success",
            pickup_code = "54238173",
            errors = "Duplicate transfer"
        };
        var url = config.BaseUrl + "/payout/{user_token}/{payout_token}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "M78j");
        parameters.Add("payout_token", "EN8n1");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "OrZiZ");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Put, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new PayoutService(mockedHttpRequest);

        var result = await service.CommitPayoutTxn("M78j", "EN8n1", "OrZiZ");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task PayoutService_GetPayoutStatus()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            payout_token = "ba4275f2-bae1-488d-9d6f-20af1cd83574",
            client_transfer_id = "aEjn345",
            source_currency_code = "USD",
            destination_currency_code = "MXN",
            source_token = "ba4275f2-bae1-488d-9d6f-20af1cd83574",
            destination_token = "d2138fd0-00be-45a8-985f-4f5bde500962",
            destination_amount = 100.5,
            source_amount = 100.5,
            attr_set_token = "b1a867c1-6e36-4525-b6d5-a20bac80e3b0",
            exchange_rate = 18.55,
            fee = 2.99,
            expiration = "2019-06-26T22:32:05",
            pickup_code = "54238173",
            status = "PENDING",
            payer_logo = "U3dhZ2dlciByb2Nrcw==",
            payer_name = "Elektra",
            delivery_type = "CASH_PICKUP",
            country_code = "MEX",
            metadata = default(object),
            estimated_availability = "2020-07-21T17:32:28Z",
            status_reason = "U4LVbsZ0",
            attrs = default(object)
        };
        var url = config.BaseUrl + "/payout/{user_token}/{payout_token}";

        var query = new Dictionary<string, object>();
        query.Add("force_status_update", false);
        query.Add("include_payer_logo", true);

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "akEmy");
        parameters.Add("payout_token", "payout_ed75acf2-1c35-4073-9adc-389084d1e96b");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "QOcdnqg");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new PayoutService(mockedHttpRequest);

        var result = await service.GetPayoutStatus("akEmy", "payout_ed75acf2-1c35-4073-9adc-389084d1e96b", true, "QOcdnqg", false);

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task PayoutService_GetTransactionConfirmationDetails()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            content = "VjZFVHo"
        };
        var url = config.BaseUrl + "/payout/{user_token}/{payout_token}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "akEmy");
        parameters.Add("payout_token", "payout_ed75acf2-1c35-4073-9adc-389084d1e96b");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "12Wq");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Patch, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new PayoutService(mockedHttpRequest);

        var result = await service.GetTransactionConfirmationDetails("akEmy", "payout_ed75acf2-1c35-4073-9adc-389084d1e96b", "12Wq");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

}
