using System;
using System.Linq;

namespace LeetSharp
{
    partial class Program
    {
        public static int DistributeCandies(int[] candies) 
        {
            var orl = candies.Length;
            candies = candies.Distinct().ToArray();
            return orl / 2 < candies.Length ? orl / 2 : candies.Length;
        }
    }
}