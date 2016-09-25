using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceParentheses
{
    public class Kata
    {
        public static bool IsBalanced(string s, string caps)
        {
            var closeStack = new Stack<char>();

            foreach (var item in s)
            {
                var capIndex = caps.IndexOf(item);
                if (capIndex > -1)
                {
                    if (capIndex % 2 == 0)
                    {
                        if (item == caps[capIndex+1] && closeStack.Count > 0 && closeStack.Peek() == item)
                        {
                            closeStack.Pop();
                        }
                        else
                        {
                            closeStack.Push(caps[capIndex + 1]);
                        }                        
                    }
                    else
                    {
                        var queueItem = closeStack.Pop();
                        if (queueItem != caps[capIndex])
                        {
                            return false;
                        }
                    }
                }
            }

            return closeStack.Count == 0;
        }
    }
}
