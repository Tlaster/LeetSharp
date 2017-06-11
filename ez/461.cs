using System;
using System.Linq;

namespace LeetSharp
{
    partial class Program
    {
        public static int HammingDistance(int x, int y) 
        {
            var count = 0;
            var max = Math.Max(x, y);
            var min = Math.Min(x, y);
            var maxS = Convert.ToString(max, 2).Reverse().ToList();
            var minS = Convert.ToString(min, 2).Reverse().ToList();
            for (int i = 0; i < minS.Count; i++)
            {
                if (minS[i] != maxS[i])
                {
                    count++;
                }
            }
            for (int i = minS.Count; i < maxS.Count; i++)
            {
                if (maxS[i] != '0')
                {
                    count++;
                }
            }
            return count;
        }
    }
}