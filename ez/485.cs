using System;
using System.Linq;

namespace LeetSharp
{
    partial class Program
    {
        public static int FindMaxConsecutiveOnes(int[] nums) 
        {
            return string.Join("", nums).Split('0').Max(m => m.Length);
        }        
    }
}