using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.Extensions
{
    public static class StringExtension
    {
        public static string ToCamelCase(this string str)
        {
            if (!string.IsNullOrEmpty(str) && str.Length > 1)
            {
                return char.ToLowerInvariant(str[0]) + str.Substring(1);
            }
            return str;
        }

        public static string ToSepararConEspacio(this string str)
        {
            return Regex.Replace(str, "([a-z])_?([A-Z])", "$1 $2");
        }

        public static string ToSepararConGuionMedioLowercase(this string str)
        {
            return Regex.Replace(str, "([a-z])_?([A-Z])", "$1-$2").ToLower();
        }
    }

}
