using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /**
     * https://leetcode.com/problems/reverse-integer/
     * */
    public static class P7_Reverse_Integer
    {
        public static int Reverse(int x)
        {
            var abs = Math.Abs( (double) x);
            int isPositive = x > 0 ? 1 : -1;
            if(abs > int.MaxValue)
            {
                return 0;
            }

            var length = Math.Floor(Math.Log10(abs) + 1) - 1;
        
            double value = 0;
            while (abs > 0)
            {
                var lastValue = abs % 10;
                value += Math.Pow(10, length) * lastValue;
                abs = (int) (abs / 10);
                length--;
            }
            value = value * isPositive;
            var isGreatThat32bits = value > int.MaxValue || value < int.MinValue;
            return isGreatThat32bits ? 0 : (int) value;
        }
    }
}
