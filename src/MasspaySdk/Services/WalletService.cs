
/**
 * MassPay API
 *
 * The version of the OpenAPI document: 0.1.4
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net.Http;
using System;
using System.Text.Json.Serialization;
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
     * @returns IEnumerable<WalletTxnResp>? Successful operation.
     * @throws ApiError
     */
    public Task<IEnumerable<WalletTxnResp>?> GetWallet(
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

        return this.HttpRequest.Request<IEnumerable<WalletTxnResp>?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Method = HttpMethod.Get,
              Path = "/wallet/{user_token}"
          }
        );
    }
    /**
   * Successful operation.
   */
    public class GetWalletResp
    {


    }



    /**
     * Get all autopay rules
     * This **GET** endpoint is used to retrieve all autopay rules currently applied to the provided wallet token. <br> You can use this endpoint to obtain information about the autopay rules associated with the wallet. <br> To use this endpoint, you need to provide the `user_token` and `wallet_token` as required parameters in the URL Path. <br> The response will include a JSON array containing details for each autopay rule, including the token, `destination_token` and percentage.
     * @param userToken Token representing the user who owns the wallet
     * @param walletToken Token representing the wallet
     * @returns IEnumerable<AutopayResp>? Succesful operation.
     * @throws ApiError
     */
    public Task<IEnumerable<AutopayResp>?> GetAutopayRules(
      string userToken,
      string walletToken
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        parameters.Add("wallet_token", walletToken);

        return this.HttpRequest.Request<IEnumerable<AutopayResp>?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Method = HttpMethod.Get,
              Path = "/wallet/{user_token}/{wallet_token}/autopay"
          }
        );
    }
    /**
   * Succesful operation.
   */
    public class GetAutopayRulesResp
    {


    }



    /**
     * Add autopay rule
     * This **POST** endpoint is used to add an autopay rule that will initiate a payout whenever the provided wallet token is loaded. <br> You can use this endpoint to create an autopay rule that automatically sends a percentage of incoming load to a specific destination. <br> To use this endpoint, you need to provide the `user_token` and `wallet_token` as required parameters in the URL Path, and the `destination_token` and percentage of incoming load that should be autopaid to the `destination_token` in the request Body. <br> The response will include a JSON object containing the details of the created autopay rule, including the token, `destination_token` and percentage.
     * @param userToken Token representing the user who owns the wallet
     * @param walletToken Token representing the wallet
     * @param requestBody Autopay rule configuration.
     * @returns AutopayResp? Succesfully created.
     * @throws ApiError
     */
    public Task<AutopayResp?> CreateAutopayRule(
      string userToken,
      string walletToken,
      AutopayRule? requestBody
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        parameters.Add("wallet_token", walletToken);

        return this.HttpRequest.Request<AutopayResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Method = HttpMethod.Post,
              Path = "/wallet/{user_token}/{wallet_token}/autopay"
          }
        );
    }




    /**
     * Delete autopay rule
     * This **DELETE** endpoint is used to delete an existing autopay rule. <br> You can use this endpoint to remove an autopay rule that is no longer needed. <br> To use this endpoint, you need to provide the `user_token` and `wallet_token` as required parameters in the URL Path, and the token of the autopay rule you wish to delete in the request Body. <br> The response will include a message indicating the success of the deletion.
     * @param userToken Token representing the user who owns the wallet
     * @param walletToken Token representing the wallet
     * @param token Autopay token to delete
     * @returns void? 
     * @throws ApiError
     */
    public Task DeleteAutopayRule(
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

        return this.HttpRequest.Request(
          new ApiRequestOptions
          {
              Params = parameters,
              Query = query,
              Method = HttpMethod.Delete,
              Path = "/wallet/{user_token}/{wallet_token}/autopay"
          }
        );
    }




}
