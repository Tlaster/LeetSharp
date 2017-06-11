using System;
using System.Linq;

namespace LeetSharp
{
    partial class Program
    {
        public static int SingleNumber(int[] nums) 
        {
            return nums.GroupBy(n => n).Where(n => n.Count() == 1).FirstOrDefault().FirstOrDefault();
        }
    }
}