using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistentBugger
{
    public class Persist
    {
        public static int Persistence(long n)
        {
            return RecPersist(n, 0);
        }

        private static int RecPersist(long n, int level)
        {
            if (n < 10)
            {
                return level;
            }

            var numbers = ConvertToArrayOfSingleNumbers(n);
            var result = numbers.Aggregate(1, (current, number) => current * number);

            return RecPersist(result, ++level);

        }

        private static ICollection<int> ConvertToArrayOfSingleNumbers(long n)
        {
            var numbers = n.ToString().ToArray();
            return numbers.Select(number => Convert.ToInt32(char.GetNumericValue(number))).ToList();
        }
    }
}
