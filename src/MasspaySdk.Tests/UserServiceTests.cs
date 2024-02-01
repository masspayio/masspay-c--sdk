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
            created_on = "2019-07-07T23:03:05",
            internal_user_id = "4324-rOzk",
            address1 = "2000 main st",
            address2 = "apt D",
            city = "Santa Monica",
            state_province = "CA",
            postal_code = "90405",
            country = "USA",
            first_name = "John",
            middle_name = "2hrZP1k",
            last_name = "Doe",
            email = "jdoe@gmail.com",
            language = "en",
            mobile_number = "16502000226",
            business_name = "ABC Company",
            timezone = "America/Los_Angeles",
            date_of_birth = "1975-03-24",
            metadata = default(object)
        };
        var url = config.BaseUrl + "/user";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new UserService(mockedHttpRequest);

        var result = await service.CreateUser(new() { InternalUserId = "4324-rOzk", Address1 = "2000 main st", Address2 = "apt D", City = "Santa Monica", StateProvince = "CA", PostalCode = "90405", Country = "USA", FirstName = "John", MiddleName = "dLDWRExWV5", LastName = "Doe", Email = "jdoe@gmail.com", Language = "en", MobileNumber = "16502000226", BusinessName = "ABC Company", DateOfBirth = "1975-03-24", Metadata = null, NotifyUser = true });

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
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
            created_on = "2019-07-07T23:03:05",
            internal_user_id = "4324-rOzk",
            address1 = "2000 main st",
            address2 = "apt D",
            city = "Santa Monica",
            state_province = "CA",
            postal_code = "90405",
            country = "USA",
            first_name = "John",
            middle_name = "K7eJldZs0",
            last_name = "Doe",
            email = "jdoe@gmail.com",
            language = "en",
            mobile_number = "16502000226",
            business_name = "ABC Company",
            timezone = "America/Los_Angeles",
            date_of_birth = "1975-03-24",
            metadata = default(object)
        };
        var url = config.BaseUrl + "/user/{user_token}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "VOp2opiGQ");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "JDsrufJ");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new UserService(mockedHttpRequest);

        var result = await service.GetUserByToken("VOp2opiGQ", "JDsrufJ");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
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
            created_on = "2019-07-07T23:03:05",
            internal_user_id = "4324-rOzk",
            address1 = "2000 main st",
            address2 = "apt D",
            city = "Santa Monica",
            state_province = "CA",
            postal_code = "90405",
            country = "USA",
            first_name = "John",
            middle_name = "rs42iok5s6",
            last_name = "Doe",
            email = "jdoe@gmail.com",
            language = "en",
            mobile_number = "16502000226",
            business_name = "ABC Company",
            timezone = "America/Los_Angeles",
            date_of_birth = "1975-03-24",
            metadata = default(object)
        };
        var url = config.BaseUrl + "/user/{user_token}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "DufHFlIi1");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "K2DvWvFV2");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Put, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new UserService(mockedHttpRequest);

        var result = await service.UpdateUser("DufHFlIi1", new() { Status = 0, CreatedOn = "2019-07-07T23:03:05", InternalUserId = "4324-rOzk", Address1 = "2000 main st", Address2 = "apt D", City = "Santa Monica", StateProvince = "CA", PostalCode = "90405", Country = "USA", FirstName = "John", MiddleName = "PJvHp0", LastName = "Doe", Email = "jdoe@gmail.com", Language = "en", MobileNumber = "16502000226", BusinessName = "ABC Company", DateOfBirth = "1975-03-24", Metadata = null }, "K2DvWvFV2");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
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
            first_name = "BaCdy",
            last_name = "pMjp",
            internal_user_id = "4324-rOzk"
        };
        var url = config.BaseUrl + "/user/lookup";

        var query = new Dictionary<string, object>();
        query.Add("email", "mGxTl8");
        query.Add("first_name", "qFZDJs");
        query.Add("internal_user_id", "Gpea8DIWFF");

        var parameters = new Dictionary<string, object>();

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "2TKh1");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new UserService(mockedHttpRequest);

        var result = await service.UserLookup("mGxTl8", "qFZDJs", "Gpea8DIWFF", "2TKh1");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
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
    type = "load",
    time_of_txn = "apCN",
    source_amount = 50.1,
    source_currency_code = "USD",
    destination_amount = 44.99,
    destination_currency_code = "mVr",
    fee = 2.98,
    status = "PENDING",
    notes = "Purchase of Candles. Order #14930",
    payer_name = "Elektra",
    pickup_code = "343432",
    source_token = "123e4567-e89b-12d3-a456-426614174000",
    destination_token = "123e4567-e89b-12d3-a456-426614174000",
    delivery_type = "CASH_PICKUP",
    client_transfer_id = "blCmjtCItjRHNFOA4aXqEVevhoqh2mkfLL6CJ6Ys4xE0x",
    status_reason = "EaeW",
    client_id = 23
}
};
        var url = config.BaseUrl + "/user/{user_token}/history";

        var query = new Dictionary<string, object>();
        query.Add("number_of_records", 10);
        query.Add("start_date", "2020-03-31");
        query.Add("end_date", "2020-03-31");
        query.Add("page", 1);
        query.Add("type", "payout");
        query.Add("wallet_token", "hDC6ihgf");
        query.Add("show_all_clients", false);

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "usr_f4741aa2-9f39-4358-8247-2409e3fc2715");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Idempotency-Key", "J1Vp");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new UserService(mockedHttpRequest);

        var result = await service.GetUserHistory("usr_f4741aa2-9f39-4358-8247-2409e3fc2715", "2020-03-31", "2020-03-31", 0, "hDC6ihgf", "J1Vp", 10, 1, false);

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

}
