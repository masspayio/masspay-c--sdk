
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


public class CatalogService
{
    public IHttpRequest HttpRequest { get; }

    public CatalogService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Gets a list of countries where services offered.
     * This **GET** endpoint is used to retrieve a list of all currently available countries of service. <br> You can use this endpoint to obtain a list of countries where MassPay services are offered. <br> There are no required parameters for this endpoint. <br> The response will include a JSON array containing details for each country, including the country code, name, and `three_letter_code`.
     * @returns IEnumerable<Country>? Successful operation.
     * @throws ApiError
     */
    public Task<IEnumerable<Country>?> GetCountryList(
    )
    {

        return this.HttpRequest.Request<IEnumerable<Country>?>(
          new ApiRequestOptions
          {
              Method = HttpMethod.Get,
              Path = "/country/list"
          }
        );
    }
    /**
   * Successful operation.
   */
    public class GetCountryListResp
    {


    }

    /**
   * Gets a list of Companies and their service offerings for the given country code.
   * This **GET** endpoint is used to retrieve a list of companies and their service offerings for a specific country. <br> You can use this endpoint to obtain information about available services and pricing for each respected company in the provided country. <br> To use this endpoint, you need to provide the `country_code` in the URL Path. <br> The response will include a JSON array containing details for each company, including the company name, service offerings, and pricing.
   * @param countryCode Country code searching services for. 3 letters [ISO_3166](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) code"
   * @param limit Limit amount for transaction amount + fee. If fee + amount are higher than the limit, the output will automatically adjust to maximize the possible amount sent
   * @param walletToken Token representing the wallet used. If provided, the results would be custom-tailored to this user. Not necessary if user_token is provided
   * @param userToken Token representing the user for which we fetch the catalog. If provided, the results would be custom-tailored to this user. Not necessary if wallet_token is provided
   * @param sourceCurrency Required if amount is provided. The currency associated with the amount
   * @param payerName Filter services that match payer name
   * @param destinationCurrency Filter services that support the destination currency
   * @param idempotencyKey Unique key to prevent duplicate processing
   * @param amount Returns the results fee based on the given amount, defaults to $200
   * @param includePayerLogos Whether to include the payers logo in base64 format. 
   * @returns CompaniesResp? Successful operation.
   * @throws ApiError
   */
    public Task<CompaniesResp?> GetCountryServices(
      string countryCode,
      double? limit,
      string? walletToken,
      string? userToken,
      string? sourceCurrency,
      string? payerName,
      string? destinationCurrency,
      string? idempotencyKey,
      string? amount = "200",
      bool? includePayerLogos = false
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("country_code", countryCode);

        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }

        var query = new Dictionary<string, object>();
        if (amount != null)
        {
            query.Add("amount", amount);
        }
        if (limit != null)
        {
            query.Add("limit", limit);
        }
        if (walletToken != null)
        {
            query.Add("wallet_token", walletToken);
        }
        if (includePayerLogos != null)
        {
            query.Add("include_payer_logos", includePayerLogos);
        }
        if (userToken != null)
        {
            query.Add("user_token", userToken);
        }
        if (sourceCurrency != null)
        {
            query.Add("source_currency", sourceCurrency);
        }
        if (payerName != null)
        {
            query.Add("payer_name", payerName);
        }
        if (destinationCurrency != null)
        {
            query.Add("destination_currency", destinationCurrency);
        }

        return this.HttpRequest.Request<CompaniesResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Get,
              Path = "/country/{country_code}"
          }
        );
    }











    /**
     * Gets a list of Companies and their cheapest service offerings for the given country code.
     * This **GET** endpoint is used to retrieve a list of companies and their cheapest service offerings for a specific country. <br> You can use this endpoint to obtain information about available services and pricing for each respected company in the provided country. If two providers offer similar services, only the cheapest option will be displayed. <br> To use this endpoint, you need to provide the `country_code` as a required parameter in the URL Path. <br> The response will include a JSON array containing details for each company, including the company name, cheapest service offerings, and pricing.
     * @param countryCode Country code searching services for. 3 letters [ISO_3166](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) code"
     * @param limit Limit amount for transaction amount + fee. If fee + amount are higher than the limit, the output will automatically adjust to maximize the possible amount sent
     * @param walletToken Token representing the wallet used. If provided, the results would be custom-tailored to this user.
     * @param userToken Token representing the user for which we fetch the catalog. If provided, the results would be custom-tailored to this user. Not necessary if wallet_token is provided
     * @param sourceCurrency Required if amount is provided. The currency associated with the amount
     * @param payerName Filter services that match payer name
     * @param destinationCurrency Filter services that support the destination currency
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @param amount Returns the results fee based on the given amount, defaults to $200
     * @param includePayerLogos Whether to include the payers logo in base64 format. 
     * @returns CompaniesResp? Successful operation.
     * @throws ApiError
     */
    public Task<CompaniesResp?> GetCheapestCountryServices(
      string countryCode,
      double? limit,
      string? walletToken,
      string? userToken,
      string? sourceCurrency,
      string? payerName,
      string? destinationCurrency,
      string? idempotencyKey,
      string? amount = "200",
      bool? includePayerLogos = false
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("country_code", countryCode);

        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }

        var query = new Dictionary<string, object>();
        if (amount != null)
        {
            query.Add("amount", amount);
        }
        if (limit != null)
        {
            query.Add("limit", limit);
        }
        if (walletToken != null)
        {
            query.Add("wallet_token", walletToken);
        }
        if (includePayerLogos != null)
        {
            query.Add("include_payer_logos", includePayerLogos);
        }
        if (userToken != null)
        {
            query.Add("user_token", userToken);
        }
        if (sourceCurrency != null)
        {
            query.Add("source_currency", sourceCurrency);
        }
        if (payerName != null)
        {
            query.Add("payer_name", payerName);
        }
        if (destinationCurrency != null)
        {
            query.Add("destination_currency", destinationCurrency);
        }

        return this.HttpRequest.Request<CompaniesResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Get,
              Path = "/country/{country_code}/cheapest"
          }
        );
    }











    /**
     * Returns list of alternative service to a provided service
     * This **GET** endpoint is used to retrieve a list of alternative services to a provided service. <br> You can use this endpoint to obtain information about other available services and pricing offered by different companies for a particular destination. <br> To use this endpoint, you need to provide the `destination_token` as a required parameter in the URL Path. <br> The response will include a JSON array containing details for each company, including the company name, available alternative services, and pricing.
     * @param destinationToken Destination token
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @returns Service? Successful operation.
     * @throws ApiError
     */
    public Task<Service?> GetDestinationTokenAlternatives(
      string destinationToken,
      string? idempotencyKey
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("destination_token", destinationToken);

        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }

        return this.HttpRequest.Request<Service?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Method = HttpMethod.Get,
              Path = "/service/{destination_token}/alternatives"
          }
        );
    }



    /**
     * Returns provided service
     * This **GET** endpoint is used to retrieve the details of the provided service. <br> To use this endpoint, you need to provide the `destination_token` as a required parameter in the URL Path. <br> The response will include a JSON object containing details for the company, including the company name, and pricing.
     * @param destinationToken Destination token
     * @param includePayerLogos Whether to include the payers logo in base64 format. 
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @returns Service? Successful operation.
     * @throws ApiError
     */
    public Task<Service?> GetDestinationToken(
      string destinationToken,
      bool? includePayerLogos,
      string? idempotencyKey
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("destination_token", destinationToken);

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

        return this.HttpRequest.Request<Service?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Get,
              Path = "/service/{destination_token}"
          }
        );
    }




    /**
     * Get user agreement
     * This **GET** endpoint is used to retrieve the user agreement for payout services. <br> You can use this endpoint to obtain information about the available user agreements for payout services offered by MassPay. <br> To use this endpoint, you need to provide the `ID` representing the user agreement as a required parameter in the URL Path. <br> The response will include the user agreement details.
     * @param id Id representing user agreement (retrieved from OPTIONS call)
     * @returns GetUserAgreementResp? Successful operation.
     * @throws ApiError
     */
    public Task<GetUserAgreementResp?> GetUserAgreement(
      int id
    )
    {

        var query = new Dictionary<string, object>();
        query.Add("id", id);

        return this.HttpRequest.Request<GetUserAgreementResp?>(
          new ApiRequestOptions
          {
              Query = query,
              Method = HttpMethod.Get,
              Path = "/user-agreements"
          }
        );
    }
    /**
   * Successful operation.
   */
    public class GetUserAgreementResp
    {
        [JsonPropertyName("name")]
        public required string Name { get; init; }
        [JsonPropertyName("content")]
        public required string Content { get; init; }
        [JsonPropertyName("last_modified")]
        public required string LastModified { get; init; }
        [JsonPropertyName("id")]
        public required int Id { get; init; }
        [JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }








    }


    /**
     * Get available user agreements
     * This OPTIONS endpoint is used to retrieve a list of available user agreements for payout services offered by MassPay without the content. <br> You can use this endpoint to obtain the names of available user agreements. <br> There are no required parameters needed to use this endpoint. <br> The response will include a list of user agreement names
     * @returns IEnumerable<GetUserAgreementsNamesResp?>? Successful operation.
     * @throws ApiError
     */
    public Task<object?> GetUserAgreementsNames(
    )
    {

        return this.HttpRequest.Request<object?>(
          new ApiRequestOptions
          {
              Method = HttpMethod.Options,
              Path = "/user-agreements"
          }
        );
    }
    /**
   * User Agreement
   */
    public class GetUserAgreementsNamesResp
    {
        [JsonPropertyName("name")]
        public required string Name { get; init; }
        [JsonPropertyName("last_modified")]
        public required string LastModified { get; init; }
        [JsonPropertyName("id")]
        public required int Id { get; init; }
        [JsonPropertyName("mime_type")]
        public required string MimeType { get; init; }







    }

}
