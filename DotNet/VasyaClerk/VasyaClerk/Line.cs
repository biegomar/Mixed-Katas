using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyaClerk
{
    using System.Diagnostics;

    public class Line
    {
        public static string Tickets(int[] peopleInLine)
        {
            foreach (var i in peopleInLine)
            {
                Console.WriteLine(i);
            }
           

            var pocket = new int[2] {0, 0};

            foreach (var people in peopleInLine)
            {
                if (!IsChangeable(pocket, people))
                {
                    return "NO";
                }
            }

            return "YES";
        }

        private static bool IsChangeable(int[] pocket, int bill)
        {
            if (bill == 25)
            {
                Change(ref pocket, bill);
                return true;
            }

            if (bill == 50 && pocket[0] >= 1)
            {
                Change(ref pocket, bill);
                return true;
            }

            if (bill == 100 && (pocket[1] >= 1 && pocket[0] >= 1) || pocket[0] >= 3)
            {
                Change(ref pocket, bill);
                return true;
            }

            return false;
        }

        private static void Change(ref int[] pocket, int bill)
        {
            if (bill == 25)
            {
                pocket[0]++;
            }

            if (bill == 50)
            {
                pocket[0]--;
                pocket[1]++;
            }

            if (bill == 100)
            {
                if (pocket[1] >= 1)
                {
                    pocket[0]--;
                    pocket[1]--;
                }
                else
                {
                    pocket[0] -= 3;
                }
            }
        }
    }
}
