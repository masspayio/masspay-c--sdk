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
    middle_name = "WY1lw",
    last_name = "Doe",
    email = "jdoe@gmail.com",
    mobile_number = "16502000226",
    business_name = "ABC Company",
    date_of_birth = "1975-03-24",
    balance = 1500,
    tax_id = "123-45-678"
}
};
        var url = config.BaseUrl + "/tax";

        var query = new Dictionary<string, object>();
        query.Add("amount_threshold", 83.50645456486382);
        query.Add("tax_year", 85);

        var parameters = new Dictionary<string, object>();

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new TaxService(mockedHttpRequest);

        var result = await service.GetTaxUsers(83.50645456486382, 85);

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
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
            interview_url = "Rc0Lk4ydl"
        };
        var url = config.BaseUrl + "/{user_token}/tax";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", "rgIlyUno");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new TaxService(mockedHttpRequest);

        var result = await service.GetTaxInterviewLink("rgIlyUno");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

}
