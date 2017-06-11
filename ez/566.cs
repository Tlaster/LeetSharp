using System;

namespace LeetSharp
{
    partial class Program
    {
        public static int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            if (nums.Length != r * c)
                return nums;
            var orr = nums.GetLength(0);
            var orc = nums.GetLength(1);
            var res = new int[r, c];
            var resr = 0;
            var resc = 0;
            for (int i = 0; i < orr; i++)
            for (int j = 0; j < orc; j++)
            {
                res[resr, resc++] = nums[i, j];
                if (resc == c)
                {
                    resr++;
                    resc = 0;
                }
            }
            return res;
        }
    }
}