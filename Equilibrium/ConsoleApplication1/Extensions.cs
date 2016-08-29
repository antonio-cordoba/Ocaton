using System;
using System.Collections.Generic;

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
    }
}
