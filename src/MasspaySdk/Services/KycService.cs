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
     * @returns Task<FindAttributesVelocityResponse>
     * @throws ApiError
     */
    public async Task<FindAttributesVelocityResponse> FindAttributesVelocity(
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
        var result = await this.HttpRequest.Request<IEnumerable<string>>(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/payout/attribute/{user_token}/velocity"
          }
        );

        return new FindAttributesVelocityResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new FindAttributesVelocityResponse.FindAttributesVelocityHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class FindAttributesVelocityResponse
    {
        public IEnumerable<string> Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required FindAttributesVelocityHeaders Headers { get; init; }

        public class FindAttributesVelocityHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
 * Get an Au10tix session link
 * This **GET** endpoint is used to obtain a link to an Au10tix session for the user with the provided user token. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path. <br> The endpoint will then generate a session link that you can use to initiate an identity verification process for the user through the Au10tix platform. <br> The response will contain the session link as a URL in a JSON format.
 * @param userToken Token representing the user to retrieve attributes for
 * @returns Task<GetUserUserTokenKycAu10TixResponse>
 * @throws ApiError
 */
    public async Task<GetUserUserTokenKycAu10TixResponse> GetUserUserTokenKycAu10Tix(
      string userToken
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        var result = await this.HttpRequest.Request<GetUserUserTokenKycAu10TixResp>(
          new ApiRequestOptions
          {
              Params = parameters,
              Method = HttpMethod.Get,
              Path = "/payout/user/{user_token}/kyc/au10tix"
          }
        );

        return new GetUserUserTokenKycAu10TixResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetUserUserTokenKycAu10TixResponse.GetUserUserTokenKycAu10TixHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetUserUserTokenKycAu10TixResponse
    {
        public GetUserUserTokenKycAu10TixResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetUserUserTokenKycAu10TixHeaders Headers { get; init; }

        public class GetUserUserTokenKycAu10TixHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Succesful operation.
   */
    public class GetUserUserTokenKycAu10TixResp
    {
        [JsonPropertyName("session_url")]
        [Newtonsoft.Json.JsonProperty("session_url", Required = Newtonsoft.Json.Required.Always)]
        public required string SessionUrl { get; init; }
    }
    /**
   * Upload ID photos
   * Upload IDs for the provided user. This is an optional endpoint if the images are captured through means other than the link that is generated in the attributes.
   * @param userToken Token representing the user to retrieve attributes for
   * @param requestBody
   * @returns Task<UploadIdPhotosResponse>
   * @throws ApiError
   */
    public async Task<UploadIdPhotosResponse> UploadIdPhotos(
      string userToken,
      IEnumerable<IdUpload>? requestBody
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        var result = await this.HttpRequest.Request(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Method = HttpMethod.Post,
              Path = "/payout/user/{user_token}/kyc/id"
          }
        );

        return new UploadIdPhotosResponse
        {
            Status = result.Status,
            Headers = new UploadIdPhotosResponse.UploadIdPhotosHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class UploadIdPhotosResponse
    {
        public HttpStatusCode Status { get; init; }
        public required UploadIdPhotosHeaders Headers { get; init; }

        public class UploadIdPhotosHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    public class UploadIdPhotosRequestBody { }
    /**
     * Get all KYC sessions
     * This **GET** endpoint is used to obtain all previous KYC sessions for the user with the provided user token. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path.
     * @param userToken Token representing the user to retrieve attributes for
     * @returns Task<GetUserUserTokenKycAttemptsResponse>
     * @throws ApiError
     */
    public async Task<GetUserUserTokenKycAttemptsResponse> GetUserUserTokenKycAttempts(
      string userToken
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        var result = await this.HttpRequest.Request<IEnumerable<KycSession>>(
          new ApiRequestOptions
          {
              Params = parameters,
              Method = HttpMethod.Get,
              Path = "/payout/user/{user_token}/kyc/id"
          }
        );

        return new GetUserUserTokenKycAttemptsResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetUserUserTokenKycAttemptsResponse.GetUserUserTokenKycAttemptsHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetUserUserTokenKycAttemptsResponse
    {
        public IEnumerable<KycSession> Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetUserUserTokenKycAttemptsHeaders Headers { get; init; }

        public class GetUserUserTokenKycAttemptsHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Succesful operation.
   */
    public class GetUserUserTokenKycAttemptsResp { }
    /**
   * Get a Veriff session link
   * This **GET** endpoint is used to obtain a link to a Veriff session for the user with the provided user token. <br> The endpoint will then generate a session link that you can use to initiate an identity verification process for the user through the Veriff platform. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path. <br> The response will contain the session link as a URL in a JSON format.
   * @param userToken Token representing the user to retrieve attributes for
   * @returns Task<GetUserUserTokenKycVeriffResponse>
   * @throws ApiError
   */
    public async Task<GetUserUserTokenKycVeriffResponse> GetUserUserTokenKycVeriff(
      string userToken
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        var result = await this.HttpRequest.Request<GetUserUserTokenKycVeriffResp>(
          new ApiRequestOptions
          {
              Params = parameters,
              Method = HttpMethod.Get,
              Path = "/payout/user/{user_token}/kyc/veriff"
          }
        );

        return new GetUserUserTokenKycVeriffResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetUserUserTokenKycVeriffResponse.GetUserUserTokenKycVeriffHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetUserUserTokenKycVeriffResponse
    {
        public GetUserUserTokenKycVeriffResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetUserUserTokenKycVeriffHeaders Headers { get; init; }

        public class GetUserUserTokenKycVeriffHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Succesful operation.
   */
    public class GetUserUserTokenKycVeriffResp
    {
        [JsonPropertyName("session_url")]
        [Newtonsoft.Json.JsonProperty("session_url", Required = Newtonsoft.Json.Required.Always)]
        public required string SessionUrl { get; init; }
    }
}
