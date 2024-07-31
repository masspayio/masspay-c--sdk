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
            expiration = "",
            pickup_code = "54238173",
            status = "PENDING",
            payer_logo = "U3dhZ2dlciByb2Nrcw==",
            payer_name = "Elektra",
            delivery_type = "CASH_PICKUP",
            country_code = "MEX",
            metadata = new object(),
            estimated_availability = "",
            status_reason = "",
            attrs = new object()
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/{user_token}");

        var query = new Dictionary<string, object>();
        query.Add("limit", 0.12);

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
        var service = new PayoutService(mockedHttpRequest);

        var result = await service.InitiatePayout("", new() { ClientTransferId = "aEjn345", SourceCurrencyCode = "USD", DestinationCurrencyCode = "MXN", SourceToken = "123e4567-e89b-12d3-a456-426614174000", DestinationToken = "123e4567-e89b-12d3-a456-426614174000", DestinationAmount = 100.5, SourceAmount = 100.5, AttrSetToken = "123e4567-e89b-12d3-a456-426614174000", Metadata = null, NotifyUser = true, AutoCommit = true }, 0.12, "");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
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
        expiration = "",
        pickup_code = "54238173",
        status = "PENDING",
        payer_logo = "U3dhZ2dlciByb2Nrcw==",
        payer_name = "Elektra",
        delivery_type = "CASH_PICKUP",
        country_code = "MEX",
        metadata = new object(),
        estimated_availability = "",
        status_reason = "",
        attrs = new object()
    }

};

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/{user_token}");

        var query = new Dictionary<string, object>();
        query.Add("include_payer_logos", true);

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
        var service = new PayoutService(mockedHttpRequest);

        var result = await service.GetUserPayoutsByToken("", "", true);

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
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

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/{user_token}/{payout_token}");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "");
        parameters.Add("payout_token", "");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "");

        var responseHeaders = new Dictionary<string, string> {
           { "Access-Control-Allow-Origin","" },
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Put, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize(expectedResponse), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new PayoutService(mockedHttpRequest);

        var result = await service.CommitPayoutTxn("", "", "");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
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
            expiration = "",
            pickup_code = "54238173",
            status = "PENDING",
            payer_logo = "U3dhZ2dlciByb2Nrcw==",
            payer_name = "Elektra",
            delivery_type = "CASH_PICKUP",
            country_code = "MEX",
            metadata = new object(),
            estimated_availability = "",
            status_reason = "",
            attrs = new object()
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/{user_token}/{payout_token}");

        var query = new Dictionary<string, object>();
        query.Add("force_status_update", true);
        query.Add("include_payer_logo", true);

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "");
        parameters.Add("payout_token", "payout_ed75acf2-1c35-4073-9adc-389084d1e96b");

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
        var service = new PayoutService(mockedHttpRequest);

        var result = await service.GetPayoutStatus("", "payout_ed75acf2-1c35-4073-9adc-389084d1e96b", true, "", true);

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
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
            content = ""
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/{user_token}/{payout_token}");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "");
        parameters.Add("payout_token", "payout_ed75acf2-1c35-4073-9adc-389084d1e96b");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "");

        var responseHeaders = new Dictionary<string, string> {
           { "Access-Control-Allow-Origin","" },
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Patch, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize(expectedResponse), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new PayoutService(mockedHttpRequest);

        var result = await service.GetTransactionConfirmationDetails("", "payout_ed75acf2-1c35-4073-9adc-389084d1e96b", "");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

}
