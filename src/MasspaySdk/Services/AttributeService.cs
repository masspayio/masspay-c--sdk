
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


public class AttributeService
{
    public IHttpRequest HttpRequest { get; }

    public AttributeService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Get all stored user attributes
     * This **GET** endpoint is used to retrieve all stored user attributes for all destination token. <br> You can use this endpoint to retrieve user attributes and provide personalized service to your users based on their preferences, demographic data, or other relevant information. <br> To use this endpoint, you need to provide the `user_token` as parameters in the URL Path. <br> The endpoint will then return all the stored attributes for the provided user in the context of the destination token. If multiple `attribute set tokens` are available, all the sets and their values will be returned.
     * @param userToken Token representing the user to retrieve attributes for
     * @returns IEnumerable<AllAttributesResp>? successful operation
     * @throws ApiError
     */
    public Task<IEnumerable<AllAttributesResp>?> GetAllAttrs(
      string userToken
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);

        return this.HttpRequest.Request<IEnumerable<AllAttributesResp>?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Method = HttpMethod.Get,
              Path = "/attribute/{user_token}"
          }
        );
    }
    /**
   * successful operation
   */
    public class GetAllAttrsResp
    {


    }


    /**
     * Store user attributes
     * This **POST** endpoint is used to store user attributes, allowing you to associate additional data with a user token. <br> To use this endpoint, you need to provide the `user_token`, `destination_token`, and `currency` as parameters in the URL Path. You also need to provide the attribute values as JSON parameters in the Request body. <br> If existing attributes are already stored for the user, this call will override their values.
     * @param userToken Token representing the user to store attributes for
     * @param destinationToken Token that represents the payout destination i.e. Omnex->Brazil->Bank Deposit->Itau. To be retrieved from the #pricing callback. 
     * @param currency The destination currency sending funds to. Using [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) format.
     * @param requestBody Attr parameters to store
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @returns StoreAttrsResp? Succesfully created.
     * @throws ApiError
     */
    public Task<StoreAttrsResp?> StoreAttrs(
      string userToken,
      string destinationToken,
      string currency,
      AttrTxn requestBody,
      string? idempotencyKey
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        parameters.Add("destination_token", destinationToken);
        parameters.Add("currency", currency);

        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }

        return this.HttpRequest.Request<StoreAttrsResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/attribute/{user_token}/{destination_token}/{currency}"
          }
        );
    }
    /**
   * Succesfully created.
   */
    public class StoreAttrsResp
    {
        [JsonPropertyName("attr_set_token")]
        public required string AttrSetToken { get; init; }




    }






    /**
     * Get user attributes for destination_token
     * This **GET** endpoint is used to retrieve user attributes for a specific destination token. <br> You can use this endpoint to retrieve user attributes and provide personalized service to your users based on their preferences, demographic data, or other relevant information. <br> To use this endpoint, you need to provide the `user_token`, `destination_token`, and `currency` as parameters in the URL Path. <br> The endpoint will then return all the required attributes for the provided user for the specified destination token. If any of the attributes already have a stored value, it will be returned as well.
     * @param userToken Token representing the user to retrieve attributes for
     * @param destinationToken Token that represents the payout destination i.e. Omnex->Brazil->Bank Deposit->Itau. To be retrieved from the #pricing callback.
     * @param currency The destination currency sending funds to. Using [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) format.
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @returns IEnumerable<AttrsRequirement>? successful operation
     * @throws ApiError
     */
    public Task<IEnumerable<AttrsRequirement>?> GetAttrs(
      string userToken,
      string destinationToken,
      string currency,
      string? idempotencyKey
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        parameters.Add("destination_token", destinationToken);
        parameters.Add("currency", currency);

        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }

        return this.HttpRequest.Request<IEnumerable<AttrsRequirement>?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Method = HttpMethod.Get,
              Path = "/attribute/{user_token}/{destination_token}/{currency}"
          }
        );
    }
    /**
   * successful operation
   */
    public class GetAttrsResp
    {


    }





}
