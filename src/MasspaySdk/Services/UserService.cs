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


public class UserService
{
    public IHttpRequest HttpRequest { get; }

    public UserService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Create a user
     * This **POST** endpoint is used to create a new user in MassPay. <br> You can use this endpoint to create a new user with the specified user details in JSON format in the request Body. <br> To use this endpoint, you need to provide the `internal_user_id`, `country`, `first_name`, `last_name`, and `email` as required parameters in the Request Body. <br> The response will include details about the newly created user.
     * @param requestBody Created user object
     * @returns Task<CreateUserResponse>
     * @throws ApiError
     */
    public async Task<CreateUserResponse> CreateUser(
      User requestBody
    )
    {
        var result = await this.HttpRequest.Request<StoredUser>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Method = HttpMethod.Post,
              Path = "/payout/user"
          }
        );

        return new CreateUserResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new CreateUserResponse.CreateUserHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class CreateUserResponse
    {
        public StoredUser Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required CreateUserHeaders Headers { get; init; }

        public class CreateUserHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
 * Get user by user token
 * This **GET** endpoint is used to retrieve a user's profile by their user token in MassPay. <br> You can use this endpoint to obtain a user profile for a specified user token. <br> To use this endpoint, you need to provide the `user_token` as a required parameter in the URL Path. <br> The response will include all available details for the user.
 * @param userToken The user token that needs to be fetched.
 * @param idempotencyKey Unique key to prevent duplicate processing
 * @returns Task<GetUserByTokenResponse>
 * @throws ApiError
 */
    public async Task<GetUserByTokenResponse> GetUserByToken(
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
        var result = await this.HttpRequest.Request<StoredUser>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Method = HttpMethod.Get,
              Path = "/payout/user/{user_token}"
          }
        );

        return new GetUserByTokenResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetUserByTokenResponse.GetUserByTokenHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetUserByTokenResponse
    {
        public StoredUser Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetUserByTokenHeaders Headers { get; init; }

        public class GetUserByTokenHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
 * Updated user
 * This **PUT** endpoint is used to update the profile information of a user with the provided user token. <br> You need to provide the `user_token` in the URL path to identify the user whose information you want to update. The updated information should be provided in the request Body as a JSON object. This endpoint can be used to update various profile information, such as the user's name, email address, phone number, and more. <br> The response will contain the updated user information in a JSON format.
 * @param userToken user token that need to be updated
 * @param requestBody Updated user object
 * @param idempotencyKey Unique key to prevent duplicate processing
 * @returns Task<UpdateUserResponse>
 * @throws ApiError
 */
    public async Task<UpdateUserResponse> UpdateUser(
      string userToken,
      UpdateUser requestBody,
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
        var result = await this.HttpRequest.Request<StoredUser>(
          new ApiRequestOptions
          {
              Params = parameters,
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Put,
              Path = "/payout/user/{user_token}"
          }
        );

        return new UpdateUserResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new UpdateUserResponse.UpdateUserHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class UpdateUserResponse
    {
        public StoredUser Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required UpdateUserHeaders Headers { get; init; }

        public class UpdateUserHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
 * Lookup an existing user
 * This **GET** endpoint is used to lookup whether a user with the provided email and first name exists in the MassPay system. <br> To use this endpoint, you need to provide the `email`, `first_name`, and `internal_user_id` as Query parameters in the URL. <br> The endpoint will then search for the user based on the provided information and return a JSON response indicating whether the user exists or not. If the user exists, the response will also contain the user's details, `user_token`, `first_name`, `last_name` and `internal_user_id`.
 * @param email User's email address. Required if First Name is provided
 * @param firstName User's first name. Required if email is provided
 * @param internalUserId A client-defined identifier for the user. This is the unique ID assigned to the user on your system. Max 75 characters. Allows letters, numbers, and + , - . / _ ~ |. Required if email and first name are not provided
 * @param idempotencyKey Unique key to prevent duplicate processing
 * @returns Task<UserLookupResponse>
 * @throws ApiError
 */
    public async Task<UserLookupResponse> UserLookup(
      string email,
      string firstName,
      string internalUserId,
      string? idempotencyKey
    )
    {
        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }
        var query = new Dictionary<string, object>();
        query.Add("email", email);
        query.Add("first_name", firstName);
        query.Add("internal_user_id", internalUserId);
        var result = await this.HttpRequest.Request<FoundUser>(
          new ApiRequestOptions
          {
              Headers = headers,
              Query = query,
              Method = HttpMethod.Get,
              Path = "/payout/user/lookup"
          }
        );

        return new UserLookupResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new UserLookupResponse.UserLookupHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class UserLookupResponse
    {
        public FoundUser Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required UserLookupHeaders Headers { get; init; }

        public class UserLookupHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
 * Transactions history
 * This **GET** endpoint is used to retrieve a list of all transactions, including payouts, loads, and spendbacks, for a provided user with the provided user token. <br> You can use this endpoint to obtain a comprehensive history of transactions for the provider user, allowing you to track and analyze their payment activities over time. <br> To use this endpoint, you need to provide the `user_token` as a parameter in the URL Path. <br> The response will contain a JSON array of transaction objects, each including transactions details.
 * @param userToken Token representing the user to get transactions history for. If none is provided, retrieve transactions for all users.
 * @param startDate Starting date
 * @param endDate Ending date
 * @param type Filter particular types of transactions. Comma separated to include multiple types
 * @param walletToken Filter transactions to include only provided wallet token.
 * @param idempotencyKey Unique key to prevent duplicate processing
 * @param numberOfRecords Number of records to return. Defaults to 10 if no value is provided
 * @param page Page number
 * @param showAllClients Whether to show transactions from all clients
 * @returns Task<GetUserHistoryResponse>
 * @throws ApiError
 */
    public async Task<GetUserHistoryResponse> GetUserHistory(
      string userToken,
      string? startDate,
      string? endDate,
      GetUserHistoryType? type,
      string? walletToken,
      string? idempotencyKey,
      double? numberOfRecords = 10,
      int? page = 1,
      bool? showAllClients = false
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
        if (numberOfRecords != null)
        {
            query.Add("number_of_records", numberOfRecords);
        }
        if (startDate != null)
        {
            query.Add("start_date", startDate);
        }
        if (endDate != null)
        {
            query.Add("end_date", endDate);
        }
        if (page != null)
        {
            query.Add("page", page);
        }
        if (type != null)
        {
            query.Add("type", type);
        }
        if (walletToken != null)
        {
            query.Add("wallet_token", walletToken);
        }
        if (showAllClients != null)
        {
            query.Add("show_all_clients", showAllClients);
        }
        var result = await this.HttpRequest.Request<IEnumerable<TxnHistoryResp>>(
          new ApiRequestOptions
          {
              Params = parameters,
              Headers = headers,
              Query = query,
              Method = HttpMethod.Get,
              Path = "/payout/user/{user_token}/history"
          }
        );

        return new GetUserHistoryResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetUserHistoryResponse.GetUserHistoryHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetUserHistoryResponse
    {
        public IEnumerable<TxnHistoryResp> Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetUserHistoryHeaders Headers { get; init; }

        public class GetUserHistoryHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Succesful operation.
   */
    public class GetUserHistoryResp { }

    /**
     * Filter particular types of transactions. Comma separated to include multiple types
     */
    [JsonConverter(typeof(StringValueEnumConverter<GetUserHistoryType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetUserHistoryType
    {
        [StringValue("payout")]
        PAYOUT,
        [StringValue("load")]
        LOAD,
        [StringValue("spendback")]
        SPENDBACK
    }    /**
     * All Users' Transactions history
     * This **GET** endpoint is used to retrieve a list of all transactions, including payouts, loads, and spendbacks, for all users. <br> You can use this endpoint to obtain a comprehensive history of transactions for all users, allowing you to track and analyze their payment activities over time. <br> The response will contain a JSON array of transaction objects, each including transactions details.
     * @param startDate Starting date
     * @param endDate Ending date
     * @param type Filter particular types of transactions. Comma separated to include multiple types
     * @param walletToken Filter transactions to include only provided wallet token.
     * @param idempotencyKey Unique key to prevent duplicate processing
     * @param numberOfRecords Number of records to return. Defaults to 10 if no value is provided
     * @param page Page number
     * @param showAllClients Whether to show transactions from all clients
     * @returns Task<GetAllUsersHistoryResponse>
     * @throws ApiError
     */
    public async Task<GetAllUsersHistoryResponse> GetAllUsersHistory(
      string? startDate,
      string? endDate,
      GetAllUsersHistoryType? type,
      string? walletToken,
      string? idempotencyKey,
      double? numberOfRecords = 10,
      int? page = 1,
      bool? showAllClients = false
    )
    {
        var headers = new Dictionary<string, string>();
        if (idempotencyKey != null)
        {
            headers.Add("Idempotency-Key", idempotencyKey);
        }
        var query = new Dictionary<string, object>();
        if (numberOfRecords != null)
        {
            query.Add("number_of_records", numberOfRecords);
        }
        if (startDate != null)
        {
            query.Add("start_date", startDate);
        }
        if (endDate != null)
        {
            query.Add("end_date", endDate);
        }
        if (page != null)
        {
            query.Add("page", page);
        }
        if (type != null)
        {
            query.Add("type", type);
        }
        if (walletToken != null)
        {
            query.Add("wallet_token", walletToken);
        }
        if (showAllClients != null)
        {
            query.Add("show_all_clients", showAllClients);
        }
        var result = await this.HttpRequest.Request<IEnumerable<TxnHistoryResp>>(
          new ApiRequestOptions
          {
              Headers = headers,
              Query = query,
              Method = HttpMethod.Get,
              Path = "/payout/user/history"
          }
        );

        return new GetAllUsersHistoryResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetAllUsersHistoryResponse.GetAllUsersHistoryHeaders
            {
                AccessControlAllowOrigin = result.RawHeaders?["Access-Control-Allow-Origin"],
            }
        };
    }

    public class GetAllUsersHistoryResponse
    {
        public IEnumerable<TxnHistoryResp> Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetAllUsersHistoryHeaders Headers { get; init; }

        public class GetAllUsersHistoryHeaders
        {
            public string AccessControlAllowOrigin { get; set; }
        }
    }
    /**
   * Succesful operation.
   */
    public class GetAllUsersHistoryResp { }

    /**
     * Filter particular types of transactions. Comma separated to include multiple types
     */
    [JsonConverter(typeof(StringValueEnumConverter<GetAllUsersHistoryType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetAllUsersHistoryType
    {
        [StringValue("payout")]
        PAYOUT,
        [StringValue("load")]
        LOAD,
        [StringValue("spendback")]
        SPENDBACK
    }
}
