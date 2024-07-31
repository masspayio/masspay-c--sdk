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
using System.Globalization;

namespace MasspaySdk.Core;

public static class Utils
{
    public static double ParseDouble(string? value)
    {
        string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        string? parsed = value;
        if (parsed != null)
        {
            if (decimalSeparator == ".")
            {
                parsed = parsed.Replace(",", ".");
            }
            else if (decimalSeparator == ",")
            {
                parsed = parsed.Replace(".", ",");
            }
        }

        return double.TryParse(parsed, NumberStyles.Any, CultureInfo.CurrentCulture, out double result) ? result : default;
    }
}
