using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpYourGranny
{
    using System.Collections;

    public class Tour
    {
        public static int tour(string[] arrFriends, string[][] ftwns, Hashtable h)
        {
            foreach (var friend in arrFriends)
            {
                var town = ftwns.FirstOrDefault(ftwn => ftwn[0] == friend);
                if (town != null)
                {
                    var distance = h[town[1]];
                }
            }
            return -1;
        }
    }
}
