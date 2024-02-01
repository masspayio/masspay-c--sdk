/**
 * MassPay API
 *
 * The version of the OpenAPI document: 0.1.4
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
namespace MasspaySdk.Core;

public interface IHttpRequest
{
    Task<T> Request<T>(ApiRequestOptions options);
    Task Request(ApiRequestOptions options);
}
