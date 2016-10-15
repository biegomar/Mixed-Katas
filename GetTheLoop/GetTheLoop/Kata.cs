using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheLoop
{    
    public class Kata
    {        
        public static int getLoopSize(LoopDetector.Node startNode)
        {
            var dict = new Dictionary<LoopDetector.Node, int>();
            var count = 0;
            var node = startNode;
            while (!dict.ContainsKey(node))
            {
                dict.Add(node, count);
                node = node.next;
                count++;
            }

            return count - dict[node];
        }           
    }
}
