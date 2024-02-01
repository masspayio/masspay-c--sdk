
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


public class TaxService
{
    public IHttpRequest HttpRequest { get; }

    public TaxService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Get list of users' annual balance
     * This **GET**  endpoint is used to get tax information for a specific user identified by their `user_token`. It provides access to historical tax attribute values as well as the ability to perform attribute velocity checks. <br>  To use this endpoint, replace `user_token` in the URL path with the actual user token of the user whose tax information you want to retrieve. This endpoint's purpose is to aid in the identification of users with matching attribute values and to prevent fraudulent activities by monitoring unusual attribute value changes over time. It compares the provided attribute value to the historical attribute values for the same user to see if it meets the velocity check criteria.
     * @param amountThreshold If specified, only show users whose total balance exceeds the provided amount
     * @param taxYear The year for which we would like to obtain tax information for. If none provided, defaults to previous year.
     * @returns IEnumerable<TaxYearUserResp>? Succesful operation.
     * @throws ApiError
     */
    public Task<IEnumerable<TaxYearUserResp>?> GetTaxUsers(
      double? amountThreshold,
      int? taxYear
    )
    {

        var query = new Dictionary<string, object>();
        if (amountThreshold != null)
        {
            query.Add("amount_threshold", amountThreshold);
        }
        if (taxYear != null)
        {
            query.Add("tax_year", taxYear);
        }

        return this.HttpRequest.Request<IEnumerable<TaxYearUserResp>?>(
          new ApiRequestOptions
          {
              Query = query,
              Method = HttpMethod.Get,
              Path = "/tax"
          }
        );
    }
    /**
   * Succesful operation.
   */
    public class GetTaxUsersResp
    {


    }



    /**
     * Get link for tax interview
     * This **GET**  endpoint is used to get a W8/W9 tax interview link for a specific user identified by their `user_token`. The user should be directed to link that is obtained by this endpoint.<br>To use this endpoint, replace `user_token` in the URL path with the actual user token of the user whose tax information you want to collect.
     * @param userToken 
     * @returns GetTaxInterviewLinkResp? OK
     * @throws ApiError
     */
    public Task<GetTaxInterviewLinkResp?> GetTaxInterviewLink(
      string userToken
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);

        return this.HttpRequest.Request<GetTaxInterviewLinkResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Method = HttpMethod.Get,
              Path = "/{user_token}/tax"
          }
        );
    }
    /**
   * OK
   */
    public class GetTaxInterviewLinkResp
    {
        [JsonPropertyName("interview_url")]
        public required string InterviewUrl { get; init; }




    }


}
