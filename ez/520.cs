using System;
using System.Linq;
namespace LeetSharp
{
    partial class Program
    {
        public static bool DetectCapitalUse(string word) 
        {
            var state = new [,]{
                {1,3},
                {2,3},
                {2,-1},
                {-1,3}
            };
            var current = 0;
            foreach (var item in word)
            {
                current = state[current, char.IsUpper(item) ? 0 : 1];
                if (current == -1)
                    return false;
            }
            return true;
        }
    }
}