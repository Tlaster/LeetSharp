using System;
using System.Linq;

namespace LeetSharp
{
    partial class Program
    {
        public static string ReverseWords(string s) 
        {
            return string.Join(" ", s.Split(' ').Select(item => new string(item.Reverse().ToArray())));
        }
    }
}