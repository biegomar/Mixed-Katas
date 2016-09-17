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
            var pairCounter = 1;
            var pair = string.Empty;
            
            foreach (var item in str)
            {
                if (pairCounter <= 2)
                {
                    pair = pair + item;
                    pairCounter++;
                }
                else
                {
                    result.Add(pair);
                    pair = item.ToString();
                    pairCounter = 1;
                }
            }

            if (pairCounter == 1)
            {
                result.Add(pair + "_");
            }

            return result.ToArray();
        }
    }
}
