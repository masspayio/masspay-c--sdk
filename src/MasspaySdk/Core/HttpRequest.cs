/**
 * MassPay API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;

namespace MasspaySdk.Core;

public class HttpRequest : IHttpRequest
{
    public static readonly string FORM_DATA_MEDIA_TYPE = "application/x-www-form-urlencoded";

    private readonly OpenAPIConfig _config;
    protected HttpClient? HttpClient { get; init; }

    public HttpRequest(OpenAPIConfig config)
    {
        this._config = config;
        this.HttpClient = null;
    }

    /**
     * Request method
     * @param options The request options from the service
     * @returns Task<ApiResponse<T>>
     * @throws ApiError
     */
    public async Task<ApiResponse<T>> Request<T>(ApiRequestOptions options)
    {
        using HttpClient httpClient = this.HttpClient ?? new() { BaseAddress = _config.BaseUrl };
        using HttpContent? content = options.Body?.GetHttpContent() ?? null;
        using HttpRequestMessage request = new(options.Method, this.BuildPath(options.Path, options.Params, options.Query))
        {
            Content = content
        };

        var headers = await GetHeaders(options);
        headers.ToList().ForEach(header => request.Headers.Add(header.Key, header.Value));

        var response = await httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            T value = await response.Content.ReadFromJsonAsync<T>() ?? throw new Exception("Response was null");
            return new ApiResponse<T>
            {
                Value = value,
                Status = response.StatusCode,
                RawHeaders = response.Headers.ToDictionary(header => header.Key, header => header.Value.First()),
            };
        }
        else
        {
            var errorBody = await response.Content.ReadFromJsonAsync<object>();
            throw new ApiError
            {
                Url = response.RequestMessage?.RequestUri?.ToString() ?? $"{_config.BaseUrl}{options.Path}",
                Status = response.StatusCode,
                StatusText = response.ReasonPhrase ?? "unknown",
                Body = errorBody,
                Request = options
            };
        }
    }

    /**
     * Request method
     * @param options The request options from the service
     * @returns Task<ApiResponse<object>>
     * @throws ApiError
     */
    public async Task<ApiResponse<object>> Request(ApiRequestOptions options)
    {
        return await this.Request<object>(options);
    }

    private async Task<IDictionary<string, string>> GetHeaders(ApiRequestOptions options)
    {
        var token = _config.Token != null ? await _config.Token(options) : null;
        var username = _config.Username != null ? await _config.Username(options) : null;
        var password = _config.Password != null ? await _config.Password(options) : null;
        var defaultHeaders = _config.Headers != null ? await _config.Headers(options) : null;

        var headers = new Dictionary<string, string>()
    {
      { "Accept", MediaTypeNames.Application.Json  },
      { "user-agent", "MasspaySdk (Csharp/2.0.0; MassPayApi/1.0.0)" },
    };
        defaultHeaders?.ToList().ForEach(header => headers[header.Key] = header.Value);
        options.Headers?.ToList().ForEach(header => headers[header.Key] = header.Value);

        if (token != null)
        {
            headers["Authorization"] = $"Bearer {token}";
        }
        else if (username != null && password != null)
        {
            headers["Authorization"] = $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}"))}";
        }

        return headers;
    }

    private Uri BuildPath(string path, IDictionary<string, object>? pathParams, IDictionary<string, object>? queryParams)
    {
        var uri = JoinUrl(this._config.BaseUrl.ToString(), path);

        if (pathParams != null)
        {
            var pathBuilder = new StringBuilder(uri);
            foreach (var pathParam in pathParams)
            {
                pathBuilder.Replace("{" + pathParam.Key + "}", pathParam.Value?.ToString() ?? "");
            }

            uri = pathBuilder.ToString();
        }

        if (queryParams != null)
        {
            var queryBuilder = new StringBuilder();
            foreach (var queryParam in queryParams)
            {
                queryBuilder.Append(queryBuilder.Length == 0 ? "?" : "&");
                queryBuilder.Append(queryParam.Key);
                queryBuilder.Append('=');

                if (queryParam.Value is Enum)
                {
                    queryBuilder.Append((queryParam.Value as Enum)?.GetStringValue() ?? "");
                }
                else
                {
                    queryBuilder.Append(queryParam.Value?.ToString() ?? "");
                }
            }

            uri += queryBuilder.ToString();
        }

        return new Uri(uri);
    }

    private static string JoinUrl(string basePath, string path)
    {
        var trimmedBasePath = basePath.Trim();
        if (trimmedBasePath.EndsWith("/"))
        {
            trimmedBasePath = trimmedBasePath.Substring(0, trimmedBasePath.Length - 1);
        }
        var trimmedPath = path.Trim();
        if (trimmedPath.StartsWith("/"))
        {
            trimmedPath = trimmedPath.Substring(1);
        }

        return $"{trimmedBasePath}/{trimmedPath}";
    }
}
