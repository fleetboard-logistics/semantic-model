using System.Collections.Generic;
using System.Text;
using static System.Char;

namespace Conizi.Model.Core.Extensions
{
    public static class StringExtensions
    {
        public static string ToCamelCase(this string str)
        {
            if (!string.IsNullOrEmpty(str) && str.Length > 1)
            {
                return ToLowerInvariant(str[0]) + str.Substring(1);
            }
            return str;
        }
    }
}
