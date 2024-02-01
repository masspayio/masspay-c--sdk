
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


public class PayoutService
{
    public IHttpRequest HttpRequest { get; }

    public PayoutService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Initiate a payout transaction
     * This **POST** endpoint is used to initiate a payout transaction from your account to a user with a specified token. <br> You can use this endpoint to pay out funds to your users, such as payments for services rendered or rewards for completing tasks. To use this endpoint, you need to provide the user token of the recipient in the URL Path. <br> The request body should include the funding source (`source_token`), payout destination (`destination_token`) and specify in which currency the payout should be made (`destination_currency_code`). <br> As a response API will return all details about your payout transaction.
     * @param userToken Token representing the user to pay out
     * @param requestBody Payout parameters for a quote
     * @param limit Limit amount for transaction amount + fee. If fee + amount are higher than the limit, the output will automatically adjust to maximize the possible amount sent
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @returns PayoutTxnResp? Successfully created.
     * @throws ApiError
     */
    public Task<PayoutTxnResp?> InitiatePayout(
      string userToken,
      PayoutTxn requestBody,
      double? limit,
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
        if (limit != null)
        {
            query.Add("limit", limit);
        }

        return this.HttpRequest.Request<PayoutTxnResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Post,
              Path = "/payout/{user_token}"
          }
        );
    }





    /**
     * Get history of payouts by user token
     * This **GET** endpoint is used to retrieve the payout history for a user with the specified token. <br> You can use this endpoint to view all payouts made to a user, including the `payout_token`, `destinantion_token` and `destination_amount`. <br> To use this endpoint, you need to provide the user token of the recipient in the URL Path. <br> The response will include a JSON object containing an array of payout transactions for the specified user, with each transaction including details such as the transaction ID, payout amount, currency, payout status, and date and time of the payout.
     * @param userToken The user token that needs to be fetched.
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @param includePayerLogos Whether to include the payers logo in base64 format. 
     * @returns IEnumerable<PayoutTxnResp>? successful operation
     * @throws ApiError
     */
    public Task<IEnumerable<PayoutTxnResp>?> GetUserPayoutsByToken(
      string userToken,
      string? idempotencyKey,
      bool? includePayerLogos = false
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
        if (includePayerLogos != null)
        {
            query.Add("include_payer_logos", includePayerLogos);
        }

        return this.HttpRequest.Request<IEnumerable<PayoutTxnResp>?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Get,
              Path = "/payout/{user_token}"
          }
        );
    }
    /**
   * successful operation
   */
    public class GetUserPayoutsByTokenResp
    {


    }




    /**
     * Commit payout transaction
     * This **PUT** endpoint is used to commit a previously created payout transaction. <br> Once a payout transaction is created, you can use this endpoint to commit the transaction and initiate the actual payout. <br> To use this endpoint, you need to provide the `user_token` and `payout_token` of the payout transaction you want to commit in the URL Path. <br> The response will include a JSON object containing details about the committed payout transaction, including the `payout_token`, `payout_status`, `pickup_code` and possible errors.
     * @param userToken Token representing the user to pay out
     * @param payoutToken Token representing the trsanaction. Retrieved from `/payout/{user_token}`
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @returns PayoutTxnCommitResp? successful operation
     * @throws ApiError
     */
    public Task<PayoutTxnCommitResp?> CommitPayoutTxn(
      string userToken,
      string payoutToken,
      string? idempotencyKey
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        parameters.Add("payout_token", payoutToken);

        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }

        return this.HttpRequest.Request<PayoutTxnCommitResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Method = HttpMethod.Put,
              Path = "/payout/{user_token}/{payout_token}"
          }
        );
    }




    /**
     * Get status of a payout by payout token
     * This **GET** endpoint is used to retrieve the status of a payout transaction for a user with the specified token and payout token. <br> You can use this endpoint to check the status of a specific payout transaction, including whether the payout has been successfully processed or if there was an error. <br> To use this endpoint, you need to provide the `user_token` and `payout_token` in the URL Path. <br> The response will include a JSON object containing details about the payout transaction.
     * @param userToken Token representing the user to pay out
     * @param payoutToken Token representing the trsanaction. Retrieved from `/payout/{user_token}`
     * @param includePayerLogo Whether to include the payer logo in base64 format. 
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @param forceStatusUpdate Attempts to get an updated status update from the payout destination
     * @returns PayoutTxnResp? OK
     * @throws ApiError
     */
    public Task<PayoutTxnResp?> GetPayoutStatus(
      string userToken,
      string payoutToken,
      bool? includePayerLogo,
      string? idempotencyKey,
      bool? forceStatusUpdate = false
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        parameters.Add("payout_token", payoutToken);

        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }

        var query = new Dictionary<string, object>();
        if (forceStatusUpdate != null)
        {
            query.Add("force_status_update", forceStatusUpdate);
        }
        if (includePayerLogo != null)
        {
            query.Add("include_payer_logo", includePayerLogo);
        }

        return this.HttpRequest.Request<PayoutTxnResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Get,
              Path = "/payout/{user_token}/{payout_token}"
          }
        );
    }






    /**
     * Get transaction confirmation details
     * This **PATCH** endpoint is used to obtain a PDF document with all the details of a payout transaction for a user with the specified token and payout token. <br> You can use this endpoint to obtain confirmation details about a specific payout transaction. <br> To use this endpoint, you need to provide the `user_token` and `payout_token` in the URL Path. <br> The response will include a PDF document containing all the details of the payout transaction.
     * @param userToken Token representing the user to pay out
     * @param payoutToken Token representing the trsanaction. Retrieved from `/payout/{user_token}`
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @returns GetTransactionConfirmationDetailsResp? OK
     * @throws ApiError
     */
    public Task<GetTransactionConfirmationDetailsResp?> GetTransactionConfirmationDetails(
      string userToken,
      string payoutToken,
      string? idempotencyKey
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        parameters.Add("payout_token", payoutToken);

        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }

        return this.HttpRequest.Request<GetTransactionConfirmationDetailsResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Method = HttpMethod.Patch,
              Path = "/payout/{user_token}/{payout_token}"
          }
        );
    }
    /**
   * OK
   */
    public class GetTransactionConfirmationDetailsResp
    {
        [JsonPropertyName("content")]
        public string? Content { get; set; }




    }




}
