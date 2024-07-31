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

public class SubaccountServiceTests
{
    [Fact]
    public async Task SubaccountService_CreateSubaccount()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            subaccount_token = "",
            api_key = ""
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/subaccount");

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
        var service = new SubaccountService(mockedHttpRequest);

        var result = await service.CreateSubaccount(new() { CompanyName = "", CompanyDba = "", Phone = "", IncDate = "", RegistrationNumber = "", Website = "", Naics = "", MinPayeeAge = 0, LegalStructure = 0, Address1 = "", Address2 = "", State = "", City = "", Zip = "", Country = "", Signer = null, Industry = 0 });

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task SubaccountService_GetSubaccountSubaccountTokenUbo()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            subaccount_ubo_token = ""
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/subaccount/{subaccount_token}/ubo");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("subaccount_token", "");

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
        var service = new SubaccountService(mockedHttpRequest);

        var result = await service.GetSubaccountSubaccountTokenUbo("", new() { OwnershipPercentage = 0.12, Phone = "", FirstName = "", MiddleName = "", LastName = "", Email = "", Dob = "", TaxId = "", Address1 = "", Address2 = "", City = "", State = "", Zip = "", Country = "" });

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

    [Fact]
    public async Task SubaccountService_UploadSubaccountUboId()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/subaccount/{subaccount_token}/ubo/{ubo_token}/id");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("subaccount_token", "");
        parameters.Add("ubo_token", "");

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var responseHeaders = new Dictionary<string, string> {
           { "Access-Control-Allow-Origin","" },
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize((new object() { })), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new SubaccountService(mockedHttpRequest);

        var result = await service.UploadSubaccountUboId("", "", new List<IdUpload>() { new() { Type = 0, Content = "" } });

        Assert.Equal("", result.Headers.AccessControlAllowOrigin);
    }

}
