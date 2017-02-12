using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePigLatin
{
    public class Kata
    {
        public static string PigIt(string str)
        {
            var tokens = str.Split(' ');
            return tokens.Aggregate(string.Empty, (current, token) => current + (token.Substring(1) + token[0] + "ay ")).Trim();            
        }
    }
}
