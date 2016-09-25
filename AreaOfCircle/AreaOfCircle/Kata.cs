using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    using System.Globalization;

    public class Kata
    {
        public static double CalculateAreaOfCircle(string radius)
        {
            try
            {
                var rad = Convert.ToDouble(radius, new NumberFormatInfo());
                if (rad <= 0 || radius.Contains(','))
                {
                    throw new ArgumentException();
                }

                return Math.Round(Math.PI * Math.Pow(rad, 2), 2);
            }
            catch (Exception)
            {

                throw new ArgumentException();
            }                        
        }
    }
}
