using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergedStringChecker
{
    public class StringMerger
    {
        public static bool isMerge(string s, string part1, string part2)
        {
            return isMergeRekursive(s, part1, part2);            
        }

        private static bool isMergeRekursive(string s, string part1, string part2)
        {
            if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(part1) && string.IsNullOrEmpty(part2))
            {
                return true;
            }

            var result = false;

            if (!string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(part1) && s[0] == part1[0])
            {
                result = isMergeRekursive(s.Substring(1), part1.Substring(1), part2);
                if (!result && !string.IsNullOrEmpty(part2) && s[0] == part2[0])
                {
                    result = isMergeRekursive(s.Substring(1), part2.Substring(1), part1);
                }
            }

            if (!string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(part2) && s[0] == part2[0])
            {
                result = isMergeRekursive(s.Substring(1), part1, part2.Substring(1));
                if (!result && !string.IsNullOrEmpty(part1) && s[0] == part2[0])
                {
                    result = isMergeRekursive(s.Substring(1), part2, part1.Substring(1));
                }
            }

            return result;
        }
    }
}