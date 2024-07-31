/**
 * MassPay API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net;

namespace MasspaySdk.Core
{
    public class ApiResponse<TValue>
    {
        public TValue? Value { get; init; } = default;
        public required HttpStatusCode Status { get; init; }
        public Dictionary<string, string>? RawHeaders { get; init; } = default;
    }
}
