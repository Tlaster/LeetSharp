using System;

namespace LeetSharp
{
    partial class Program
    {
        public static int IslandPerimeter(int[,] grid)
        {
            var r = grid.GetLength(0);
            var c = grid.GetLength(1);
            var count = 0;
            for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
            {
                if (grid[i,j] == 0)
                    continue;
                var co = 4;
                if (i > 0 && grid[i-1, j] == 1)
                    co--;
                if (i < r-1 && grid[i+1, j] == 1)
                    co--;
                if (j > 0 && grid[i, j-1] == 1)
                    co--;
                if (j < c-1 && grid[i, j+1] == 1)
                    co--;
                count+=co;
            }
            return count;
        }        
    }
}