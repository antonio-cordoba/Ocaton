﻿using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public static class Extensions
    {
        public static string JoinString(this IEnumerable<string> ie)
        {
            return String.Join(string.Empty, ie);
        }

    }
}