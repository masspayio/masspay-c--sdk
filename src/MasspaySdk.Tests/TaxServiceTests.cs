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

public class TaxServiceTests
{
    [Fact]
    public async Task TaxService_GetTaxUsers()
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
        user_token = "123e4567-e89b-12d3-a456-426614174000",
        address1 = "2000 main st",
        address2 = "apt D",
        city = "Santa Monica",
        state_province = "CA",
        postal_code = 90405,
        country = "USA",
        first_name = "John",
        middle_name = "",
        last_name = "Doe",
        email = "jdoe@gmail.com",
        mobile_number = "16502000226",
        business_name = "ABC Company",
        date_of_birth = "",
        balance = 1500,
        tax_id = "123-45-678"
    }

};

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/tax");

        var query = new Dictionary<string, object>();
        query.Add("amount_threshold", 0.12);
        query.Add("tax_year", 0);

        var parameters = new Dictionary<string, object>();

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
        var service = new TaxService(mockedHttpRequest);

        var result = await service.GetTaxUsers(0.12, 0);

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task TaxService_GetTaxInterviewLink()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            interview_url = ""
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/payout/{user_token}/tax");

        var query = new Dictionary<string, object>();
        query.Add("return_url", "https://www.masspay.io");

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
        var service = new TaxService(mockedHttpRequest);

        var result = await service.GetTaxInterviewLink("", "https://www.masspay.io");

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

}
