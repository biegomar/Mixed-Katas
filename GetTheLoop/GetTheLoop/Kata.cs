using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheLoop
{    
    public class Kata
    {
        private static List<LoopDetector.Node> list = new List<LoopDetector.Node>();  
        public static int getLoopSize(LoopDetector.Node startNode)
        {
            var loopEntry = getLoopEntryNode(startNode);            
            var diff = getCountFromStartToLoopEntry(startNode, loopEntry.Item2);
            return loopEntry.Item1 - diff;
        }

        private static Tuple<int, LoopDetector.Node> getLoopEntryNode(LoopDetector.Node startNode)
        {
            if (!list.Contains(startNode))
            {
                list.Add(startNode);
                var result = getLoopEntryNode(startNode.next);
                return new Tuple<int, LoopDetector.Node>(result.Item1 + 1, result.Item2);
            }
            return new Tuple<int, LoopDetector.Node>(0, startNode);
        }

        private static int getCountFromStartToLoopEntry(LoopDetector.Node startNode, LoopDetector.Node loopEntryNode)
        {            
            if (startNode != loopEntryNode)
            {                
                return 1 + getCountFromStartToLoopEntry(startNode.next, loopEntryNode);
            }
            return 0;
        }
    }
}
