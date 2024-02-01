
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
     * @returns IEnumerable<SpendBacks>? Succesful operation.
     * @throws ApiError
     */
    public Task<IEnumerable<SpendBacks>?> GetUserSpendbacksByToken(
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

        return this.HttpRequest.Request<IEnumerable<SpendBacks>?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Method = HttpMethod.Get,
              Path = "/spendback/{user_token}"
          }
        );
    }
    /**
   * Succesful operation.
   */
    public class GetUserSpendbacksByTokenResp
    {


    }



    /**
     * Initiate a spend back transaction
     * This **POST** endpoint is used to initiate a spendback transaction to a provided user token. <br> You can use this endpoint to enable spendback transactions for your users and help them manage their funds more effectively. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path, along with the required parameters in the request Body, including `client_spendback_id`, `source_token`, `source_currency_code` and `amount`. <br> The endpoint will then initiate the spendback transaction, transferring funds from the source token to the user token. The response will contain a JSON object indicating the status of the request and any relevant transaction details.
     * @param userToken Token representing the user to fetch/initiate spend back
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @param requestBody Spend back information
     * @returns SpendBackTxnResp? Succesfully created.
     * @throws ApiError
     */
    public Task<SpendBackTxnResp?> InitiateSpendback(
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

        return this.HttpRequest.Request<SpendBackTxnResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/spendback/{user_token}"
          }
        );
    }




}
