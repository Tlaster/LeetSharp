using System;
using System.Linq;

namespace LeetSharp
{
    partial class Program
    {
        public static string ReverseString(string s) 
        {
            return string.Join("", s.Reverse());
        }
    }
}