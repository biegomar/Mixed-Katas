using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyaClerk
{
    public class Line
    {
        public static string Tickets(int[] peopleInLine)
        {
            var pocket = 0;

            foreach (var people in peopleInLine)
            {
                pocket -= (people - 25);
                if (pocket < 0)
                {
                    return "NO";
                }
                pocket += 25;
            }

            return "YES";
        }
    }
}
