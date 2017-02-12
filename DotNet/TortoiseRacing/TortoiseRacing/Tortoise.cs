using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseRacing
{
    public class Tortoise
    {
        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2)
            {
                return null;
            }

            var timeInSeconds = (float)g / ((float)v2 / 3600 - (float)v1 / 3600);

            var resultHours = (int)timeInSeconds / 3600;
            timeInSeconds = timeInSeconds - 3600 * resultHours;

            var resultMinutes = (int)timeInSeconds / 60;
            timeInSeconds = Math.Abs(timeInSeconds - 60 * resultMinutes);

            return new int[] { resultHours, resultMinutes, (int)timeInSeconds };
        }
    }
}
