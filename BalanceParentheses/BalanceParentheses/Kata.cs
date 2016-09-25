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
            var acceptedCaps = string.Empty;
            var index = 0;
            foreach (var item in caps)
            {
                if (index % 2 == 0)
                {
                    acceptedCaps += item;
                }
                index++;
            }
            return recursiveBalancer(s, caps, acceptedCaps);
        }

        private static bool recursiveBalancer(string s, string caps, string acceptedCaps)
        {
            var index = 0;
            while (!caps.Contains(s[index]))
            {
                index++;
            }

            if (acceptedCaps.Contains(s[index]))
            {
                var newAcceptedCaps = string.Empty;
                var capsIndex = 0;
                foreach (var item in caps)
                {
                    if (capsIndex % 2 == 0)
                    {
                        newAcceptedCaps += item;
                        if (s[capsIndex] == item)
                        {
                            newAcceptedCaps += caps[capsIndex + 1];
                        }
                    }
                    capsIndex++;
                }

                return recursiveBalancer(s.Substring(index + 1), caps, newAcceptedCaps);
            }

            return false;
        }
    }
}
