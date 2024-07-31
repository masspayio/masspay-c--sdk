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


public class AccountService
{
    public IHttpRequest HttpRequest { get; }

    public AccountService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Get current available balance
     * This **GET** endpoint is used to retrieve the current available balance for the MassPay account. <br> You can use this endpoint to obtain information about the current balance in your account. <br> There are no required parameters needed to access this endpoint. <br> The response will include a JSON objects containing details for the current available balance, including the token, balance and `currency_code`.
     * @returns Task<GetAccountBalanceResponse>
     * @throws ApiError
     */
    public async Task<GetAccountBalanceResponse> GetAccountBalance(
    )
    {
        var result = await this.HttpRequest.Request<IEnumerable<AvailableBalanceTxnResp>>(
          new ApiRequestOptions
          {
              Method = HttpMethod.Get,
              Path = "/payout/account/balance"
          }
        );

        return new GetAccountBalanceResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetAccountBalanceResponse.GetAccountBalanceHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetAccountBalanceResponse
    {
        public IEnumerable<AvailableBalanceTxnResp> Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetAccountBalanceHeaders Headers { get; init; }

        public class GetAccountBalanceHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * successful operation
   */
    public class GetAccountBalanceResp { }
    /**
   * Get certified account statement
   * This **GET** endpoint is used to retrieve a certified PDF ledger statement for a provided timeframe. <br> You can use this endpoint to obtain a ledger statement for your MassPay account for a specific time period. <br> To use this endpoint, you need to provide the `start_date` and `ending_date` as required parameters in the Query string of the URL. <br> The response will include a certified PDF ledger statement containing transaction details for the specified timeframe.
   * @param startDate Starting date of the statement
   * @param endingDate Ending date of the statement (not more than 31 days than `start_date`)
   * @returns Task<GetAccountStatementResponse>
   * @throws ApiError
   */
    public async Task<GetAccountStatementResponse> GetAccountStatement(
      string startDate,
      string endingDate
    )
    {
        var query = new Dictionary<string, object>();
        query.Add("start_date", startDate);
        query.Add("ending_date", endingDate);
        var result = await this.HttpRequest.Request<GetAccountStatementResp>(
          new ApiRequestOptions
          {
              Query = query,
              Method = HttpMethod.Get,
              Path = "/payout/account/statement"
          }
        );

        return new GetAccountStatementResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetAccountStatementResponse.GetAccountStatementHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetAccountStatementResponse
    {
        public GetAccountStatementResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetAccountStatementHeaders Headers { get; init; }

        public class GetAccountStatementHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Successful operation.
   */
    public class GetAccountStatementResp
    {
        [JsonPropertyName("content")]
        [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.Always)]
        public required string Content { get; init; }
    }
}
