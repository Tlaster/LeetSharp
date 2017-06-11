using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetSharp
{
    partial class Program
    {
        public static int[] NextGreaterElement(int[] findNums, int[] nums)
        {
            var res = new List<int>();
            var tem = nums.ToList();
            for (int i = 0; i < findNums.Length; i++)
            {
                var index = tem.FindIndex(tem.IndexOf(findNums[i]), n => n > findNums[i]);
                if (index != -1)
                {
                    index = tem[index];
                }
                res.Add(index);
            }
            return res.ToArray();
        } 
    }
}