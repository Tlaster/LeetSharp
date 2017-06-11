using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetSharp
{
    partial class Program
    {
        public static string[] FindRestaurant(string[] list1, string[] list2) 
        {
            var li1 = list1.ToList();
            var li2 = list2.ToList();
            return list1.Intersect(list2)
            .Select(item => new { index = li1.IndexOf(item) + li2.IndexOf(item), value = item})
            .GroupBy(item => item.index)
            .OrderBy(item => item.Key)
            .FirstOrDefault().Select(item => item.value).ToArray();
        }
    }
}