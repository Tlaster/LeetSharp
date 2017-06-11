using System;
using System.Linq;
namespace LeetSharp
{
    partial class Program
    {
        public int AddDigits(int num) 
        {
            if (num < 10)
                return num;
            var sta = num.ToString().ToCharArray();
            var res = 0;
            foreach (var item in sta)
                res += int.Parse(item.ToString());
            return AddDigits(res);
        }
    }
}