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


public class LoadService
{
    public IHttpRequest HttpRequest { get; }

    public LoadService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Resend balance notification
     * This **PUT** endpoint is used to resend a balance notification to a user with the specified `user_token`. The balance notification informs the user about the current balance in their account. <br> To use this endpoint, you need to provide the required parameter `user_token` in the URL Path. Additionally, you have the option to include an optional parameter `wallet_token` in the query parameters. The `wallet_token` can be used to specify a particular wallet associated with the user, if applicable. <br> Upon a successful request, the API will return a boolean response indicating the success of the balance notification resend operation.
     * @param userToken Token representing the user who owns the wallet
     * @param walletToken Optional wallet token. If none is provided, select the first wallet available
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @returns Task<ResendBalanceNotificationResponse>
     * @throws ApiError
     */
    public async Task<ResendBalanceNotificationResponse> ResendBalanceNotification(
      string userToken,
      string? walletToken,
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
        var query = new Dictionary<string, object>();
        if (walletToken != null)
        {
            query.Add("wallet_token", walletToken);
        }
        var result = await this.HttpRequest.Request<ResendBalanceNotificationResp>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Put,
              Path = "/payout/wallet/{user_token}"
          }
        );

        return new ResendBalanceNotificationResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new ResendBalanceNotificationResponse.ResendBalanceNotificationHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class ResendBalanceNotificationResponse
    {
        public ResendBalanceNotificationResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required ResendBalanceNotificationHeaders Headers { get; init; }

        public class ResendBalanceNotificationHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * OK
   */
    public class ResendBalanceNotificationResp
    {
        [JsonPropertyName("success")]
        [Newtonsoft.Json.JsonProperty("success", Required = Newtonsoft.Json.Required.Always)]
        public required bool Success { get; init; }
    }
    /**
   * Initiate a load transaction
   * This **POST** endpoint is used to initiate a load transaction, allowing you to add funds to a user token's wallet. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path. You also need to provide the `client_load_id`, `source_token`, and amount as JSON parameters in the Request Body. The `client_load_id` is a unique identifier for the transaction that you can use to track it, while the `source_token` is the token or account from which the funds will be loaded. The amount parameter specifies the amount of funds to be loaded into the user's wallet. <br> The response will contain a JSON object indicating the status of the load transaction and any relevant details.
   * @param userToken Token representing the user to load
   * @param requestBody Load information
   * @param idempotencyKey Unique key to prevent duplicate processing
   * @returns Task<LoadUserResponse>
   * @throws ApiError
   */
    public async Task<LoadUserResponse> LoadUser(
      string userToken,
      LoadTxn requestBody,
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
        var result = await this.HttpRequest.Request<LoadTxnResp>(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/payout/load/{user_token}"
          }
        );

        return new LoadUserResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new LoadUserResponse.LoadUserHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class LoadUserResponse
    {
        public LoadTxnResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required LoadUserHeaders Headers { get; init; }

        public class LoadUserHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
 * Get history of loads by user token
 * This **GET** endpoint is used to retrieve a transaction history of all loads that were made to the provided user token, including scheduled loads. <br> You can use this endpoint to obtain a comprehensive history of loads for the user token, allowing you to track and analyze their incoming payments over time. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path. <br> The endpoint will then return a JSON array of load transactions, each including transactions details.
 * @param userToken The user token that needs to be fetched.
 * @param idempotencyKey Unique key to prevent duplicate processing
 * @returns Task<GetUserLoadsByTokenResponse>
 * @throws ApiError
 */
    public async Task<GetUserLoadsByTokenResponse> GetUserLoadsByToken(
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
        var result = await this.HttpRequest.Request<IEnumerable<Loads>>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Method = HttpMethod.Get,
              Path = "/payout/load/{user_token}"
          }
        );

        return new GetUserLoadsByTokenResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetUserLoadsByTokenResponse.GetUserLoadsByTokenHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetUserLoadsByTokenResponse
    {
        public IEnumerable<Loads> Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetUserLoadsByTokenHeaders Headers { get; init; }

        public class GetUserLoadsByTokenHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Successful operation.
   */
    public class GetUserLoadsByTokenResp { }
    /**
   * Resend load notification
   * This **PUT** endpoint is used to resend a load notification to the user associated with the provided `user_token` for a specific load transaction. <br> You can use this endpoint to help ensure that users are notified promptly and accurately of any incoming funds or other important payment events. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path, and the `load_token` as a parameter in the Query string. The endpoint will then resend a notification to the user for the specified load transaction. <br> The response will contain a JSON object indicating the status of the request.
   * @param userToken Token representing the user to load/fetch loads for
   * @param loadToken Load token
   * @param idempotencyKey Unique key to prevent duplicate processing
   * @returns Task<ResendLoadNotificationResponse>
   * @throws ApiError
   */
    public async Task<ResendLoadNotificationResponse> ResendLoadNotification(
      string userToken,
      string loadToken,
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
        var query = new Dictionary<string, object>();
        query.Add("load_token", loadToken);
        var result = await this.HttpRequest.Request<ResendLoadNotificationResp>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Put,
              Path = "/payout/load/{user_token}"
          }
        );

        return new ResendLoadNotificationResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new ResendLoadNotificationResponse.ResendLoadNotificationHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class ResendLoadNotificationResponse
    {
        public ResendLoadNotificationResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required ResendLoadNotificationHeaders Headers { get; init; }

        public class ResendLoadNotificationHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Succesful operation.
   */
    public class ResendLoadNotificationResp
    {
        [JsonPropertyName("success")]
        [Newtonsoft.Json.JsonProperty("success", Required = Newtonsoft.Json.Required.Always)]
        public required bool Success { get; init; }
    }
    /**
   * Reverse a user load
   * This **DELETE** endpoint is used to reverse a load transaction that was already processed, allowing you to remove funds from a user's wallet. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path, and the load_token as a parameter in the Query string. <br> The endpoint will then attempt to reverse the specified load transaction. If the load is still in scheduled status, it will be marked as cancelled.
   * @param userToken Token representing the user to load/fetch loads for
   * @param loadToken Load token
   * @param idempotencyKey Unique key to prevent duplicate processing
   * @returns Task<CancelUserLoadResponse>
   * @throws ApiError
   */
    public async Task<CancelUserLoadResponse> CancelUserLoad(
      string userToken,
      string loadToken,
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
        var query = new Dictionary<string, object>();
        query.Add("load_token", loadToken);
        var result = await this.HttpRequest.Request(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Delete,
              Path = "/payout/load/{user_token}"
          }
        );

        return new CancelUserLoadResponse
        {
            Status = result.Status,
        };
    }

    public class CancelUserLoadResponse
    {
        public HttpStatusCode Status { get; init; }
    }
}
