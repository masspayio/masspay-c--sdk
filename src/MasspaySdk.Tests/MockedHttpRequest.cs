using MasspaySdk.Core;
using RichardSzalay.MockHttp;
using System.Net.Http;
using System.Text;

namespace MasspaySdk.Tests;

internal class MockedHttpRequest : HttpRequest
{
    public HttpClient MockedHttpClient { get; }

    public MockedHttpRequest(OpenAPIConfig config, MockHttpMessageHandler mockHttpMessageHandler) : base(config)
    {
        this.MockedHttpClient = mockHttpMessageHandler.ToHttpClient();
        base.HttpClient = this.MockedHttpClient;
    }

    public static string BuildPath(string path, Dictionary<string, object> pathParams, Dictionary<string, object> queryParams)
    {
        var uri = path;

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
                queryBuilder.Append(queryParam.Value?.ToString() ?? "");
            }

            uri += queryBuilder.ToString();
        }

        return uri;
    }

    public static string JoinUrl(string basePath, string path)
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
