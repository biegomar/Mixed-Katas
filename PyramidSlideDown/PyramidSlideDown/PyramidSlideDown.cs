using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidSlideDown
{
    public class PyramidSlideDown
    {
        private static int[][] _pyramid;

        private static int _highestSum;
        public static int LongestSlideDown(int[][] pyramid)
        {
            _pyramid = pyramid;
            _highestSum = 0;
            longestSlideDownRec(0, 0, 0);

            return _highestSum;
        }

        private static void longestSlideDownRec(int level, int index, int sum)
        {
            var pathSum = sum + _pyramid[level][index];
            if (level < _pyramid.Length-1)
            {
                longestSlideDownRec(level + 1, index, pathSum);               
                longestSlideDownRec(level, index + 1, pathSum);
            }

            if (_highestSum < pathSum)
            {
                _highestSum = pathSum;
            }
        }
    }
}
