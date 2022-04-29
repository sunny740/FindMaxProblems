using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNum
{
    public class MaxNumber
    {
        public int FindMaxInteger(int first, int second, int third)
        {
            if (first.CompareTo(second) < 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Number Is Greater");
                return first;
            }
            if (second.CompareTo(second) < 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Number Is Greater");
                return first;
            }
            else
            {
                return third;
            }
        }
        
    }
}
