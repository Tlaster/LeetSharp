using System;
using System.Linq;

namespace LeetSharp
{
    partial class Program
    {
        public static int FindComplement(int num) 
        {
            var str = Convert.ToString(num, 2).ToList();
            for (int i = 0; i < str.Count; i++)
            {
                str[i] = str[i] == '0' ? '1' : '0';
            }
            return Convert.ToInt32(string.Join("", str), 2);
        }
    }
}