
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


public class KycService
{
    public IHttpRequest HttpRequest { get; }

    public KycService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Attributes velocity check
     * This **POST** endpoint is used to perform an attributes velocity check to identify users with matching attribute values. <br> You can use this endpoint to help prevent fraudulent activities by monitoring for unusual attribute value changes over time. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL path and the required parameters in the request Body. <br> The endpoint will then compare the provided attribute value with the historical attribute values for the same user and determine if it meets the velocity check criteria.
     * @param userToken Token representing the user to retrieve attributes for
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @param requestBody 
     * @returns IEnumerable<IDictionary<string, object?>?>? Succesfully created.
     * @throws ApiError
     */
    public Task<IDictionary<string, object?>?> FindAttributesVelocity(
      string userToken,
      string? idempotencyKey,
      AttrVelocityRequest? requestBody
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);

        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }

        return this.HttpRequest.Request<IDictionary<string, object?>?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/attribute/{user_token}/velocity"
          }
        );
    }
    public class FindAttributesVelocityResp
    {


    }




    /**
     * Get an Au10tix session link
     * This **GET** endpoint is used to obtain a link to an Au10tix session for the user with the provided user token. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path. <br> The endpoint will then generate a session link that you can use to initiate an identity verification process for the user through the Au10tix platform. <br> The response will contain the session link as a URL in a JSON format.
     * @param userToken 
     * @returns GetUserUserTokenKycAu10TixResp? Succesful operation.
     * @throws ApiError
     */
    public Task<GetUserUserTokenKycAu10TixResp?> GetUserUserTokenKycAu10Tix(
      string userToken
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);

        return this.HttpRequest.Request<GetUserUserTokenKycAu10TixResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Method = HttpMethod.Get,
              Path = "/user/{user_token}/kyc/au10tix"
          }
        );
    }
    /**
   * Succesful operation.
   */
    public class GetUserUserTokenKycAu10TixResp
    {
        [JsonPropertyName("session_url")]
        public required string SessionUrl { get; init; }




    }


    /**
     * Upload ID photos
     * Upload IDs for the provided user. This is an optional endpoint if the images are captured through means other than the link that is generated in the attributes.
     * @param userToken 
     * @param requestBody 
     * @returns IDictionary<string, object?>? OK
     * @throws ApiError
     */
    public Task<object?> UploadIdPhotos(
      string userToken,
      IEnumerable<IdUpload>? requestBody
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);

        return this.HttpRequest.Request<object?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Method = HttpMethod.Post,
              Path = "/user/{user_token}/kyc/id"
          }
        );
    }



    public class UploadIdPhotosRequestBody
    {


    }
    /**
     * Get a Veriff session link
     * This **GET** endpoint is used to obtain a link to a Veriff session for the user with the provided user token. <br> The endpoint will then generate a session link that you can use to initiate an identity verification process for the user through the Veriff platform. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path. <br> The response will contain the session link as a URL in a JSON format.
     * @param userToken 
     * @returns GetUserUserTokenKycVeriffResp? Succesful operation.
     * @throws ApiError
     */
    public Task<GetUserUserTokenKycVeriffResp?> GetUserUserTokenKycVeriff(
      string userToken
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);

        return this.HttpRequest.Request<GetUserUserTokenKycVeriffResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Method = HttpMethod.Get,
              Path = "/user/{user_token}/kyc/veriff"
          }
        );
    }
    /**
   * Succesful operation.
   */
    public class GetUserUserTokenKycVeriffResp
    {
        [JsonPropertyName("session_url")]
        public required string SessionUrl { get; init; }




    }


}
