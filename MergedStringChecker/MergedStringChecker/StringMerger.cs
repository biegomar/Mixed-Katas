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
            Console.WriteLine("s: {0}", s);
            Console.WriteLine("part1: {0}", part1);
            Console.WriteLine("part2: {0}", part2);

            if (!isMergeRekursive(s, part1, part2))
            {
                return isMergeRekursive(s, part2, part1);
            }

            return true;
        }

        private static bool isMergeRekursive(string s, string part1, string part2)
        {
            if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(part1) && string.IsNullOrEmpty(part2))
            {
                return true;
            }

            if (!string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(part1) && s[0] == part1[0])
            {
                return isMergeRekursive(s.Substring(1), part1.Substring(1), part2);
            }

            if (!string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(part2) && s[0] == part2[0])
            {
                return isMergeRekursive(s.Substring(1), part1, part2.Substring(1));
            }

            return false;
        }
    }
}