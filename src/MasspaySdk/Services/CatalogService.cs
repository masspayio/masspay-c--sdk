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
     * @returns Task<GetCountryListResponse>
     * @throws ApiError
     */
    public async Task<GetCountryListResponse> GetCountryList(
    )
    {
        var result = await this.HttpRequest.Request<IEnumerable<Country>>(
          new ApiRequestOptions
          {
              Method = HttpMethod.Get,
              Path = "/payout/country/list"
          }
        );

        return new GetCountryListResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetCountryListResponse.GetCountryListHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetCountryListResponse
    {
        public IEnumerable<Country> Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetCountryListHeaders Headers { get; init; }

        public class GetCountryListHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Successful operation.
   */
    public class GetCountryListResp { }
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
   * @returns Task<GetCountryServicesResponse>
   * @throws ApiError
   */
    public async Task<GetCountryServicesResponse> GetCountryServices(
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
        var result = await this.HttpRequest.Request<CompaniesResp>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Get,
              Path = "/payout/country/{country_code}"
          }
        );

        return new GetCountryServicesResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetCountryServicesResponse.GetCountryServicesHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetCountryServicesResponse
    {
        public CompaniesResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetCountryServicesHeaders Headers { get; init; }

        public class GetCountryServicesHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
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
 * @returns Task<GetCheapestCountryServicesResponse>
 * @throws ApiError
 */
    public async Task<GetCheapestCountryServicesResponse> GetCheapestCountryServices(
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
        var result = await this.HttpRequest.Request<CompaniesResp>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Get,
              Path = "/payout/country/{country_code}/cheapest"
          }
        );

        return new GetCheapestCountryServicesResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetCheapestCountryServicesResponse.GetCheapestCountryServicesHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetCheapestCountryServicesResponse
    {
        public CompaniesResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetCheapestCountryServicesHeaders Headers { get; init; }

        public class GetCheapestCountryServicesHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
 * Returns list of alternative service to a provided service
 * This **GET** endpoint is used to retrieve a list of alternative services to a provided service. <br> You can use this endpoint to obtain information about other available services and pricing offered by different companies for a particular destination. <br> To use this endpoint, you need to provide the `destination_token` as a required parameter in the URL Path. <br> The response will include a JSON array containing details for each company, including the company name, available alternative services, and pricing.
 * @param destinationToken Destination token
 * @param idempotencyKey Unique key to prevent duplicate processing
 * @returns Task<GetDestinationTokenAlternativesResponse>
 * @throws ApiError
 */
    public async Task<GetDestinationTokenAlternativesResponse> GetDestinationTokenAlternatives(
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
        var result = await this.HttpRequest.Request<Service>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Method = HttpMethod.Get,
              Path = "/payout/service/{destination_token}/alternatives"
          }
        );

        return new GetDestinationTokenAlternativesResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetDestinationTokenAlternativesResponse.GetDestinationTokenAlternativesHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetDestinationTokenAlternativesResponse
    {
        public Service Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetDestinationTokenAlternativesHeaders Headers { get; init; }

        public class GetDestinationTokenAlternativesHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
 * Returns provided service
 * This **GET** endpoint is used to retrieve the details of the provided service. <br> To use this endpoint, you need to provide the `destination_token` as a required parameter in the URL Path. <br> The response will include a JSON object containing details for the company, including the company name, and pricing.
 * @param destinationToken Destination token
 * @param includePayerLogos Whether to include the payers logo in base64 format. 
 * @param idempotencyKey Unique key to prevent duplicate processing
 * @returns Task<GetDestinationTokenResponse>
 * @throws ApiError
 */
    public async Task<GetDestinationTokenResponse> GetDestinationToken(
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
        var result = await this.HttpRequest.Request<Service>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Get,
              Path = "/payout/service/{destination_token}"
          }
        );

        return new GetDestinationTokenResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetDestinationTokenResponse.GetDestinationTokenHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetDestinationTokenResponse
    {
        public Service Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetDestinationTokenHeaders Headers { get; init; }

        public class GetDestinationTokenHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
 * Get user agreement
 * This **GET** endpoint is used to retrieve the user agreement for payout services. <br> You can use this endpoint to obtain information about the available user agreements for payout services offered by MassPay. <br> To use this endpoint, you need to provide the `ID` representing the user agreement as a required parameter in the URL Path. <br> The response will include the user agreement details.
 * @param id Id representing user agreement (retrieved from OPTIONS call)
 * @returns Task<GetUserAgreementResponse>
 * @throws ApiError
 */
    public async Task<GetUserAgreementResponse> GetUserAgreement(
      int id
    )
    {
        var query = new Dictionary<string, object>();
        query.Add("id", id);
        var result = await this.HttpRequest.Request<GetUserAgreementResp>(
          new ApiRequestOptions
          {
              Query = query,
              Method = HttpMethod.Get,
              Path = "/payout/user-agreements"
          }
        );

        return new GetUserAgreementResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetUserAgreementResponse.GetUserAgreementHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetUserAgreementResponse
    {
        public GetUserAgreementResp Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetUserAgreementHeaders Headers { get; init; }

        public class GetUserAgreementHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Successful operation.
   */
    public class GetUserAgreementResp
    {
        [JsonPropertyName("name")]
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public required string Name { get; init; }
        [JsonPropertyName("content")]
        [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.Always)]
        public required string Content { get; init; }
        [JsonPropertyName("last_modified")]
        [Newtonsoft.Json.JsonProperty("last_modified", Required = Newtonsoft.Json.Required.Always)]
        public required string LastModified { get; init; }
        [JsonPropertyName("id")]
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public required int Id { get; init; }
        [JsonPropertyName("mime_type")]
        [Newtonsoft.Json.JsonProperty("mime_type", Required = Newtonsoft.Json.Required.DisallowNull)]
        public string MimeType { get; set; }
    }
    /**
   * Get available user agreements
   * This OPTIONS endpoint is used to retrieve a list of available user agreements for payout services offered by MassPay without the content. <br> You can use this endpoint to obtain the names of available user agreements. <br> There are no required parameters needed to use this endpoint. <br> The response will include a list of user agreement names
   * @returns Task<GetUserAgreementsNamesResponse>
   * @throws ApiError
   */
    public async Task<GetUserAgreementsNamesResponse> GetUserAgreementsNames(
    )
    {
        var result = await this.HttpRequest.Request<IEnumerable<GetUserAgreementsNamesResp>>(
          new ApiRequestOptions
          {
              Method = HttpMethod.Options,
              Path = "/payout/user-agreements"
          }
        );

        return new GetUserAgreementsNamesResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetUserAgreementsNamesResponse.GetUserAgreementsNamesHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetUserAgreementsNamesResponse
    {
        public IEnumerable<GetUserAgreementsNamesResp> Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetUserAgreementsNamesHeaders Headers { get; init; }

        public class GetUserAgreementsNamesHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * User Agreement
   */
    public class GetUserAgreementsNamesResp
    {
        [JsonPropertyName("name")]
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public required string Name { get; init; }
        [JsonPropertyName("last_modified")]
        [Newtonsoft.Json.JsonProperty("last_modified", Required = Newtonsoft.Json.Required.Always)]
        public required string LastModified { get; init; }
        [JsonPropertyName("id")]
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public required int Id { get; init; }
        [JsonPropertyName("mime_type")]
        [Newtonsoft.Json.JsonProperty("mime_type", Required = Newtonsoft.Json.Required.Always)]
        public required string MimeType { get; init; }
    }
}
