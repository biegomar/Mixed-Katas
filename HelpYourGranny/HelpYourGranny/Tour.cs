using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpYourGranny
{
    using System.Collections;
    using System.Diagnostics;

    public class Tour
    {
        public static int tour(string[] arrFriends, string[][] ftwns, Hashtable h)
        {
            var fromTown = "X0";
            double totalDistance = 0;
            foreach (var friend in arrFriends)
            {
                var town = ftwns.FirstOrDefault(ftwn => ftwn[0] == friend);
                if (town != null)
                {
                    var toTown = town[1];
                    var distance = Convert.ToInt32(h[toTown]);
                    
                    if (fromTown == "X0")
                    {
                        totalDistance += distance;                        
                    }
                    else
                    {
                        var a = Convert.ToInt32(h[fromTown]);
                        var c = distance;
                        totalDistance += CalcRoute(a, c);
                    }
                    fromTown = toTown;
                }
            }            
            var closeCircuitDistance =  Convert.ToInt32(h[fromTown]);
            
            return Convert.ToInt32(Math.Truncate(totalDistance + closeCircuitDistance));
        }

        private static double CalcRoute(int a, int c)
        {            
            return Math.Sqrt(c * c - a * a);
        }
    }
}
