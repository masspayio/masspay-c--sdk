/**
 * MassPay API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net.Http;
using System;
using System.Net;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using MasspaySdk.Models;
using MasspaySdk.Core;

namespace MasspaySdk.Services;


public class SubaccountService
{
    public IHttpRequest HttpRequest { get; }

    public SubaccountService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Create a subaccount
     * This **POST** endpoint is used to initiate create a subaccount under your organization. <br> You can use this endpoint to establish subaccounts which you can use to transact through the MassPay platform. <br> To use this endpoint, you need to provide the required parameters in the request Body, including `company_name`, `company_dba`, `incorporation_date`,  and other corporate related details. <br> The endpoint will then return a successful subaccount token for the newly created entity. The response will contain a JSON object indicating the status of the request and any relevant subaccount details.
     * @param requestBody
     * @returns Task<CreateSubaccountResponse>
     * @throws ApiError
     */
    public async Task<CreateSubaccountResponse> CreateSubaccount(
      CreateSubaccountTxn? requestBody
    )
    {
        var result = await this.HttpRequest.Request<CreateSubaccountResp>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Method = HttpMethod.Post,
              Path = "/subaccount"
          }
        );

        return new CreateSubaccountResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new CreateSubaccountResponse.CreateSubaccountHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class CreateSubaccountResponse
    {
        public CreateSubaccountResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required CreateSubaccountHeaders Headers { get; init; }

        public class CreateSubaccountHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * OK
   */
    public class CreateSubaccountResp
    {
        [JsonPropertyName("subaccount_token")]
        [Newtonsoft.Json.JsonProperty("subaccount_token", Required = Newtonsoft.Json.Required.Always)]
        public required string SubaccountToken { get; init; }
        [JsonPropertyName("api_key")]
        [Newtonsoft.Json.JsonProperty("api_key", Required = Newtonsoft.Json.Required.Always)]
        public required string ApiKey { get; init; }
    }
    /**
   * Add UBOs to subaccount
   * This **POST** endpoint is used to add UBOs to a subaccount under your organization. <br> To use this endpoint, you need to provide the required parameters in the request Body, including `first_name`, `last_name`, `tax_id`,  and other UBO details. <br> The endpoint will then return a successful subaccount UBO token for the newly added UBO. The response will contain a JSON object indicating the status of the request and any relevant subaccount UBO details.
   * @param subaccountToken
   * @param requestBody
   * @returns Task<GetSubaccountSubaccountTokenUboResponse>
   * @throws ApiError
   */
    public async Task<GetSubaccountSubaccountTokenUboResponse> GetSubaccountSubaccountTokenUbo(
      string subaccountToken,
      AddUboRequest? requestBody
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("subaccount_token", subaccountToken);
        var result = await this.HttpRequest.Request<GetSubaccountSubaccountTokenUboResp>(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Method = HttpMethod.Post,
              Path = "/subaccount/{subaccount_token}/ubo"
          }
        );

        return new GetSubaccountSubaccountTokenUboResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetSubaccountSubaccountTokenUboResponse.GetSubaccountSubaccountTokenUboHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetSubaccountSubaccountTokenUboResponse
    {
        public GetSubaccountSubaccountTokenUboResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetSubaccountSubaccountTokenUboHeaders Headers { get; init; }

        public class GetSubaccountSubaccountTokenUboHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * OK
   */
    public class GetSubaccountSubaccountTokenUboResp
    {
        [JsonPropertyName("subaccount_ubo_token")]
        [Newtonsoft.Json.JsonProperty("subaccount_ubo_token", Required = Newtonsoft.Json.Required.Always)]
        public required string SubaccountUboToken { get; init; }
    }
    /**
   * Upload UBO ID photos
   * This **POST** endpoint is used to upload UBOs IDs. <br> Upload IDs for the provided UBO.
   * @param subaccountToken
   * @param uboToken
   * @param requestBody
   * @returns Task<UploadSubaccountUboIdResponse>
   * @throws ApiError
   */
    public async Task<UploadSubaccountUboIdResponse> UploadSubaccountUboId(
      string subaccountToken,
      string uboToken,
      IEnumerable<IdUpload>? requestBody
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("subaccount_token", subaccountToken);
        parameters.Add("ubo_token", uboToken);
        var result = await this.HttpRequest.Request(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Method = HttpMethod.Post,
              Path = "/subaccount/{subaccount_token}/ubo/{ubo_token}/id"
          }
        );

        return new UploadSubaccountUboIdResponse
        {
            Status = result.Status,
            Headers = new UploadSubaccountUboIdResponse.UploadSubaccountUboIdHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class UploadSubaccountUboIdResponse
    {
        public HttpStatusCode Status { get; init; }
        public required UploadSubaccountUboIdHeaders Headers { get; init; }

        public class UploadSubaccountUboIdHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    public class UploadSubaccountUboIdRequestBody { }
}
