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
            for (var i = n.ToString().Length - 1; i > 0; i--)
            {
                if (Convert.ToInt16(tokens[i]) > Convert.ToInt16(tokens[i-1]))
                {
                    var swapIndex = i-1;
                    var higherIndex = i;
                    for (var j = n.ToString().Length - 1; j >= i; j--)
                    {
                        if (tokens[j] < tokens[higherIndex] && tokens[swapIndex] < tokens[j])
                        {
                            higherIndex = j;
                        }
                    }

                    SwapItem(tokens, swapIndex, higherIndex);

                    var resultList = ResultList(tokens, i);
                    return Convert.ToInt64(new string(resultList.ToArray()));
                }
            }
            return result;
        }

        private static char[] ResultList(List<char> tokens, int i)
        {
            var sortArray = new char[tokens.Count - i];
            tokens.CopyTo(i, sortArray, 0, tokens.Count - i);
            var sortList = sortArray.ToList();
            sortList.Sort();
            var resultList = new char[tokens.Count];
            tokens.CopyTo(0, resultList, 0, i);
            sortList.CopyTo(0, resultList, i, sortList.Count);
            return resultList;
        }

        private static void SwapItem(List<char> tokens, int swapIndex, int higherIndex)
        {
            var swapItem = tokens[swapIndex];
            tokens[swapIndex] = tokens[higherIndex];
            tokens[higherIndex] = swapItem;
        }
    }
}
