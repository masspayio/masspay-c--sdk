/**
 * MassPay API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
namespace MasspaySdk.Core;

public interface IHttpRequest
{
    Task<ApiResponse<T>> Request<T>(ApiRequestOptions options);
    Task<ApiResponse<object>> Request(ApiRequestOptions options);
}
