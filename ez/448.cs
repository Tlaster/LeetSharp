using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetSharp
{
    partial class Program
    {
        public IList<int> FindDisappearedNumbers(int[] nums) 
        {
            var comp = new List<int>();
            for (int i = 1; i <= nums.Length; i++)
                comp.Add(i);
            return comp.Except(nums).ToList();
        }
    }
}