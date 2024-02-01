/**
 * MassPay API
 *
 * The version of the OpenAPI document: 0.1.4
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net;

namespace MasspaySdk.Core;

public class ApiError : Exception
{
    public required string Url { get; init; }
    public required HttpStatusCode Status { get; init; }
    public string? StatusText { get; set; }
    public required object? Body { get; init; }
    public required ApiRequestOptions Request { get; init; }
}
