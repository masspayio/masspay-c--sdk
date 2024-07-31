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

public class UserServiceTests
{
    [Fact]
    public async Task UserService_CreateUser()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            user_token = "123e4567-e89b-12d3-a456-426614174000",
            status = "ACTIVE",
            created_on = "",
            internal_user_id = "4324-rOzk",
            address1 = "2000 main st",
            address2 = "apt D",
            city = "Santa Monica",
            state_province = "CA",
            postal_code = "90405",
            country = "USA",
            first_name = "John",
            middle_name = "",
            last_name = "Doe",
            email = "jdoe@gmail.com",
            language = "en",
            mobile_number = "16502000226",
            business_name = "ABC Company",
            timezone = "America/Los_Angeles",
            date_of_birth = "",
            metadata = new object(),
            activation_url = "https://members.masspay.io/activation?activation=AO=="
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/user");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();

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
        var service = new UserService(mockedHttpRequest);

        var result = await service.CreateUser(new() { InternalUserId = "4324-rOzk", Address1 = "2000 main st", Address2 = "apt D", City = "Santa Monica", StateProvince = "CA", PostalCode = "90405", Country = "USA", FirstName = "John", MiddleName = "", LastName = "Doe", Email = "jdoe@gmail.com", Language = "en", MobileNumber = "16502000226", BusinessName = "ABC Company", DateOfBirth = "", Metadata = null, NotifyUser = true });

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task UserService_GetUserByToken()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            user_token = "123e4567-e89b-12d3-a456-426614174000",
            status = "ACTIVE",
            created_on = "",
            internal_user_id = "4324-rOzk",
            address1 = "2000 main st",
            address2 = "apt D",
            city = "Santa Monica",
            state_province = "CA",
            postal_code = "90405",
            country = "USA",
            first_name = "John",
            middle_name = "",
            last_name = "Doe",
            email = "jdoe@gmail.com",
            language = "en",
            mobile_number = "16502000226",
            business_name = "ABC Company",
            timezone = "America/Los_Angeles",
            date_of_birth = "",
            metadata = new object(),
            activation_url = "https://members.masspay.io/activation?activation=AO=="
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/user/{user_token}");

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
        var service = new UserService(mockedHttpRequest);

        var result = await service.GetUserByToken("", "");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task UserService_UpdateUser()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            user_token = "123e4567-e89b-12d3-a456-426614174000",
            status = "ACTIVE",
            created_on = "",
            internal_user_id = "4324-rOzk",
            address1 = "2000 main st",
            address2 = "apt D",
            city = "Santa Monica",
            state_province = "CA",
            postal_code = "90405",
            country = "USA",
            first_name = "John",
            middle_name = "",
            last_name = "Doe",
            email = "jdoe@gmail.com",
            language = "en",
            mobile_number = "16502000226",
            business_name = "ABC Company",
            timezone = "America/Los_Angeles",
            date_of_birth = "",
            metadata = new object(),
            activation_url = "https://members.masspay.io/activation?activation=AO=="
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/user/{user_token}");

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
        var mock = mockHttp.When(HttpMethod.Put, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize(expectedResponse), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new UserService(mockedHttpRequest);

        var result = await service.UpdateUser("", new() { Status = 0, CreatedOn = "", InternalUserId = "4324-rOzk", Address1 = "2000 main st", Address2 = "apt D", City = "Santa Monica", StateProvince = "CA", PostalCode = "90405", Country = "USA", FirstName = "John", MiddleName = "", LastName = "Doe", Email = "jdoe@gmail.com", Language = "en", MobileNumber = "16502000226", BusinessName = "ABC Company", DateOfBirth = "", Metadata = null }, "");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task UserService_UserLookup()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            user_token = "usr_f4741aa2-9f39-4358-8247-2409e3fc2715",
            first_name = "",
            last_name = "",
            internal_user_id = "4324-rOzk"
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/user/lookup");

        var query = new Dictionary<string, object>();
        query.Add("email", "");
        query.Add("first_name", "");
        query.Add("internal_user_id", "");

        var parameters = new Dictionary<string, object>();

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
        var service = new UserService(mockedHttpRequest);

        var result = await service.UserLookup("", "", "", "");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task UserService_GetUserHistory()
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
        token = "123e4567-e89b-12d3-a456-426614174000",
        type = "payout",
        time_of_txn = "",
        source_amount = 50.1,
        source_currency_code = "USD",
        destination_amount = 44.99,
        destination_currency_code = "",
        fee = 2.98,
        status = "READY_FOR_PICKUP",
        notes = "Purchase of Candles. Order #14930",
        payer_name = "Elektra",
        pickup_code = "343432",
        source_token = "123e4567-e89b-12d3-a456-426614174000",
        destination_token = "123e4567-e89b-12d3-a456-426614174000",
        delivery_type = "CASH_PICKUP",
        client_transfer_id = "",
        status_reason = "",
        client_id = 0,
        user_token = ""
    }

};

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/user/{user_token}/history");

        var query = new Dictionary<string, object>();
        query.Add("number_of_records", 10);
        query.Add("start_date", "");
        query.Add("end_date", "");
        query.Add("page", 1);
        query.Add("type", "payout");
        query.Add("wallet_token", "");
        query.Add("show_all_clients", true);

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "usr_f4741aa2-9f39-4358-8247-2409e3fc2715");

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
        var service = new UserService(mockedHttpRequest);

        var result = await service.GetUserHistory("usr_f4741aa2-9f39-4358-8247-2409e3fc2715", "", "", UserService.GetUserHistoryType.PAYOUT, "", "", 10, 1, true);

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task UserService_GetAllUsersHistory()
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
        token = "123e4567-e89b-12d3-a456-426614174000",
        type = "payout",
        time_of_txn = "",
        source_amount = 50.1,
        source_currency_code = "USD",
        destination_amount = 44.99,
        destination_currency_code = "",
        fee = 2.98,
        status = "READY_FOR_PICKUP",
        notes = "Purchase of Candles. Order #14930",
        payer_name = "Elektra",
        pickup_code = "343432",
        source_token = "123e4567-e89b-12d3-a456-426614174000",
        destination_token = "123e4567-e89b-12d3-a456-426614174000",
        delivery_type = "CASH_PICKUP",
        client_transfer_id = "",
        status_reason = "",
        client_id = 0,
        user_token = ""
    }

};

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/user/history");

        var query = new Dictionary<string, object>();
        query.Add("number_of_records", 10);
        query.Add("start_date", "");
        query.Add("end_date", "");
        query.Add("page", 1);
        query.Add("type", "payout");
        query.Add("wallet_token", "");
        query.Add("show_all_clients", true);

        var parameters = new Dictionary<string, object>();

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
        var service = new UserService(mockedHttpRequest);

        var result = await service.GetAllUsersHistory("", "", UserService.GetAllUsersHistoryType.PAYOUT, "", "", 10, 1, true);

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

}
