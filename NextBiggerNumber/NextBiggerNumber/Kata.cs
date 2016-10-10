using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBiggerNumber
{
    public class Kata
    {
        public static long NextBiggerNumber(long n)
        {
            long result = -1;
            var tokens = n.ToString().ToList();
            for (int i = n.ToString().Length - 1; i > 0; i--)
            {
                if (Convert.ToInt16(tokens[i]) > Convert.ToInt16(tokens[i-1]))
                {
                    var swap = tokens[i];
                    tokens[i] = tokens[i - 1];
                    tokens[i - 1] = swap;

                    var sortArray = new char[tokens.Count - i];
                    tokens.CopyTo(i, sortArray, 0, tokens.Count - i);
                    var sortList = sortArray.ToList();
                    sortList.Sort();
                    var resultList = new char[tokens.Count];
                    tokens.CopyTo(0, resultList, 0, i);
                    sortList.CopyTo(0, resultList, i, sortList.Count);
                    return Convert.ToInt64(new string(resultList.ToArray()));
                }
            }
            return result;
        }
    }
}
