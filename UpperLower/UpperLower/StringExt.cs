using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLower
{
    public static class StringExt
    {
        public static string ToAlternatingCase(this string s)
        {
            return s.Aggregate(string.Empty, (current, item) => current + (char.IsUpper(item) ? char.ToLower(item) : char.ToUpper(item)));
        }
    }
}
