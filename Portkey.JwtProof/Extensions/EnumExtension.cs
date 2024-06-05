using System.ComponentModel;
using System.Reflection;
using JWT.Builder;

namespace Portkey.JwtProof.Extensions;

internal static class EnumExtensions
{
    /// <summary>
    /// Gets the string representation of a well-known header name enum
    /// </summary>
    public static string GetHeaderName(this HeaderName value) =>
        GetDescription(value);

    /// <summary>
    /// Gets the string representation of a well-known claim name enum
    /// </summary>
    public static string GetPublicClaimName(this ClaimName value) =>
        GetDescription(value);

    /// <summary>
    /// Gets the value of the <see cref="DescriptionAttribute" /> from the object.
    /// </summary>
    private static string GetDescription<T>(T value)
    {
        var valueString = value.ToString();
        return value.GetType()
            .GetField(valueString)
            .GetCustomAttribute<DescriptionAttribute>()
            ?.Description ?? valueString;
    }
}