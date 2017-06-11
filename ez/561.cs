using System;
using System.Linq;

namespace LeetSharp
{
    partial class Program
    {
        public static int ArrayPairSum(int[] nums)
        {
            nums = nums.OrderBy(n =>n).ToArray();
            var res = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                res += nums[i];
            }
            return res;
        }
    }
}