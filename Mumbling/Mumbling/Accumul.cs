using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbling
{
    public class Accumul
    {
        public static String Accum(string s)
        {
            var result = "";
            for (var i = 0; i < s.Length; i++)
            {
                if (i > 0)
                {
                    result = result + "-";
                }

                for (var j = 0; j <= i; j++)
                {                
                    if (j == 0)
                    {
                        result = result + s[i].ToString().ToUpper();
                    }
                    else
                    {
                        result = result + s[i].ToString().ToLower();
                    }                  
                    
                }
            }

            return result;
        }
    }
}
