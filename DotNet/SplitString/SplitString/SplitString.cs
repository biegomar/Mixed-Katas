using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitString
{
    using System.Diagnostics;

    public class SplitString
    {
        public static string[] Solution(string str)
        {
            var result = new List<string>();            
            var pair = string.Empty;
            
            foreach (var item in str)
            {
                if (pair.Length < 2)
                {
                    pair = pair + item;                    
                }
                else
                {
                    result.Add(pair);
                    pair = item.ToString();                    
                }
            }

            if (pair.Length == 1)
            {
                result.Add(pair + "_");
            }
            else if (pair.Length == 2)
            {
                result.Add(pair);
            }

            return result.ToArray();
        }
    }
}
