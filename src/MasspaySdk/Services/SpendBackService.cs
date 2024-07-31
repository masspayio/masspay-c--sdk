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


public class SpendBackService
{
    public IHttpRequest HttpRequest { get; }

    public SpendBackService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Get history of spend backs by user token
     * This **GET** endpoint is used to retrieve the history of spendbacks for a specific user token. <br> You can use this endpoint to help manage your payment operations and track the usage of funds by your users. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path. <br> The endpoint will then return a list of all the historical spendbacks for the provided user token. The response will contain a JSON array with details for each spendback transaction.
     * @param userToken Token representing the user to fetch/initiate spend back
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @returns Task<GetUserSpendbacksByTokenResponse>
     * @throws ApiError
     */
    public async Task<GetUserSpendbacksByTokenResponse> GetUserSpendbacksByToken(
      string userToken,
      string? idempotencyKey
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }
        var result = await this.HttpRequest.Request<IEnumerable<SpendBacks>>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Method = HttpMethod.Get,
              Path = "/payout/spendback/{user_token}"
          }
        );

        return new GetUserSpendbacksByTokenResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetUserSpendbacksByTokenResponse.GetUserSpendbacksByTokenHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetUserSpendbacksByTokenResponse
    {
        public IEnumerable<SpendBacks> Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetUserSpendbacksByTokenHeaders Headers { get; init; }

        public class GetUserSpendbacksByTokenHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Succesful operation.
   */
    public class GetUserSpendbacksByTokenResp { }
    /**
   * Initiate a spend back transaction
   * This **POST** endpoint is used to initiate a spendback transaction to a provided user token. <br> You can use this endpoint to enable spendback transactions for your users and help them manage their funds more effectively. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path, along with the required parameters in the request Body, including `client_spendback_id`, `source_token`, `source_currency_code` and `amount`. <br> The endpoint will then initiate the spendback transaction, transferring funds from the source token to the user token. The response will contain a JSON object indicating the status of the request and any relevant transaction details.
   * @param userToken Token representing the user to fetch/initiate spend back
   * @param idempotencyKey Unique key to prevent duplicate processing
   * @param requestBody Spend back information
   * @returns Task<InitiateSpendbackResponse>
   * @throws ApiError
   */
    public async Task<InitiateSpendbackResponse> InitiateSpendback(
      string userToken,
      string? idempotencyKey,
      SpendBackTxn? requestBody
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }
        var result = await this.HttpRequest.Request<SpendBackTxnResp>(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/payout/spendback/{user_token}"
          }
        );

        return new InitiateSpendbackResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new InitiateSpendbackResponse.InitiateSpendbackHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class InitiateSpendbackResponse
    {
        public SpendBackTxnResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required InitiateSpendbackHeaders Headers { get; init; }

        public class InitiateSpendbackHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
}
