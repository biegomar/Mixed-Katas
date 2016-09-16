using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParityOutlier
{
    public class Kata
    {
        public static int Find(int[] integers)
        {
            var even = 0;
            var odd = 0;
            var evenCounter = 0;
            foreach (var number in integers)
            {
                if (number % 2 == 0)
                {
                    even = number;
                    evenCounter++;
                }
                else
                {
                    odd = number;
                }
            }

            return evenCounter > 1 ? odd : even;
        }
    }
}
