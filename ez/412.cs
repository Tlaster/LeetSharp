using System;
using System.Collections.Generic;

namespace LeetSharp
{
    partial class Program
    {
        public static IList<string> FizzBuzz(int n) 
        {
            var list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                var t = i % 3 == 0;
                var f = i % 5 == 0;
                if (t && f)
                {
                    list.Add("FizzBuzz");
                }
                else if (t)
                {
                    list.Add("Fizz");
                } 
                else if (f)
                {
                    list.Add("Buzz");
                }
                else 
                {
                    list.Add(i.ToString());
                }
            }
            return list;
        }        
    }
}