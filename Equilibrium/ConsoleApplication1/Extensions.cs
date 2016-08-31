using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace ConsoleApplication1
{
    public static class Extensions
    {
        public static string JoinString(this IEnumerable<string> ie)
        {
            return String.Join(string.Empty, ie);
        }

        public static int JoinToInt(this IEnumerable<char> ie)
        {
            return int.Parse(String.Join(string.Empty, ie));
        }

        public static char[] ToPaddedCharArray(this int value, int len, char pad)
        {
            return value.ToString().PadRight(len, pad).ToCharArray();
        }
        public static IEnumerable<Match> Matches(this string value, string regex)
        {
            return Regex.Matches(value, regex).Cast<Match>();
        }
    }
}
