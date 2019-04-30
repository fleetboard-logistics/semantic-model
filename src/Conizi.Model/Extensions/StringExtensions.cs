using System;

namespace Conizi.Model.Extensions
{
    internal static class StringExtensions
    {
        internal static string ToCamelCase(this string str)
        {
            if (!string.IsNullOrEmpty(str) && str.Length > 1)
            {
                return Char.ToLowerInvariant(str[0]) + str.Substring(1);
            }

            return str;
        }
    }
}
