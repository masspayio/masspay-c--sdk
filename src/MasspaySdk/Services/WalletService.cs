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


public class WalletService
{
    public IHttpRequest HttpRequest { get; }

    public WalletService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Retrieve all available wallets for a user
     * This **GET** endpoint is used to retrieve all available wallets for a provided user token. <br> You can use this endpoint to obtain information about the wallets associated with the provided user token. <br> To use this endpoint, you need to provide the `user_token` as a required parameter in the URL Path. <br> The response will include a JSON array containing details for each wallet including `user_token`, `balance`, `currency_code`.
     * @param userToken Token representing the user who owns the wallet
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @returns Task<GetWalletResponse>
     * @throws ApiError
     */
    public async Task<GetWalletResponse> GetWallet(
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
        var result = await this.HttpRequest.Request<IEnumerable<WalletTxnResp>>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Method = HttpMethod.Get,
              Path = "/payout/wallet/{user_token}"
          }
        );

        return new GetWalletResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetWalletResponse.GetWalletHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetWalletResponse
    {
        public IEnumerable<WalletTxnResp> Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetWalletHeaders Headers { get; init; }

        public class GetWalletHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Successful operation.
   */
    public class GetWalletResp { }
    /**
   * Get all AutoPayout rules
   * This **GET** endpoint is used to retrieve all autopayout rules currently applied to the provided wallet token. <br> You can use this endpoint to obtain information about the autopayout rules associated with the wallet. <br> To use this endpoint, you need to provide the `user_token` and `wallet_token` as required parameters in the URL Path. <br> The response will include a JSON array containing details for each autopayout rule, including the token, `destination_token` and percentage.
   * @param userToken Token representing the user who owns the wallet
   * @param walletToken Token representing the wallet
   * @returns Task<GetAutopayoutRulesResponse>
   * @throws ApiError
   */
    public async Task<GetAutopayoutRulesResponse> GetAutopayoutRules(
      string userToken,
      string walletToken
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        parameters.Add("wallet_token", walletToken);
        var result = await this.HttpRequest.Request<IEnumerable<AutopayoutResp>>(
          new ApiRequestOptions
          {
              Params = parameters,
              Method = HttpMethod.Get,
              Path = "/payout/wallet/{user_token}/{wallet_token}/autopayout"
          }
        );

        return new GetAutopayoutRulesResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetAutopayoutRulesResponse.GetAutopayoutRulesHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetAutopayoutRulesResponse
    {
        public IEnumerable<AutopayoutResp> Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetAutopayoutRulesHeaders Headers { get; init; }

        public class GetAutopayoutRulesHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Succesful operation.
   */
    public class GetAutopayoutRulesResp { }
    /**
   * Add AutoPayout rule
   * This **POST** endpoint is used to add an autopayout rule that will initiate a payout whenever the provided wallet token is loaded. <br> You can use this endpoint to create an autopayout rule that automatically sends a percentage of incoming load to a specific destination. <br> To use this endpoint, you need to provide the `user_token` and `wallet_token` as required parameters in the URL Path, and the `destination_token` and percentage of incoming load that should be autopaid to the `destination_token` in the request Body. <br> The response will include a JSON object containing the details of the created autopayout rule, including the token, `destination_token` and percentage.
   * @param userToken Token representing the user who owns the wallet
   * @param walletToken Token representing the wallet
   * @param requestBody Autopayout rule configuration.
   * @returns Task<CreateAutopayoutRuleResponse>
   * @throws ApiError
   */
    public async Task<CreateAutopayoutRuleResponse> CreateAutopayoutRule(
      string userToken,
      string walletToken,
      AutopayRule? requestBody
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        parameters.Add("wallet_token", walletToken);
        var result = await this.HttpRequest.Request<AutopayoutResp>(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Method = HttpMethod.Post,
              Path = "/payout/wallet/{user_token}/{wallet_token}/autopayout"
          }
        );

        return new CreateAutopayoutRuleResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new CreateAutopayoutRuleResponse.CreateAutopayoutRuleHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class CreateAutopayoutRuleResponse
    {
        public AutopayoutResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required CreateAutopayoutRuleHeaders Headers { get; init; }

        public class CreateAutopayoutRuleHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
 * Delete AutoPayout rule
 * This **DELETE** endpoint is used to delete an existing autopayout rule. <br> You can use this endpoint to remove an autopayout rule that is no longer needed. <br> To use this endpoint, you need to provide the `user_token` and `wallet_token` as required parameters in the URL Path, and the token of the autopayout rule you wish to delete in the request Body. <br> The response will include a message indicating the success of the deletion.
 * @param userToken Token representing the user who owns the wallet
 * @param walletToken Token representing the wallet
 * @param token Autopayout token to delete
 * @returns Task<DeleteAutopayoutRuleResponse>
 * @throws ApiError
 */
    public async Task<DeleteAutopayoutRuleResponse> DeleteAutopayoutRule(
      string userToken,
      string walletToken,
      string token
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        parameters.Add("wallet_token", walletToken);
        var query = new Dictionary<string, object>();
        query.Add("token", token);
        var result = await this.HttpRequest.Request(
          new ApiRequestOptions
          {
              Params = parameters,
              Query = query,
              Method = HttpMethod.Delete,
              Path = "/payout/wallet/{user_token}/{wallet_token}/autopayout"
          }
        );

        return new DeleteAutopayoutRuleResponse
        {
            Status = result.Status,
        };
    }

    public class DeleteAutopayoutRuleResponse
    {
        public HttpStatusCode Status { get; init; }
    }
}
