using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public static  class P9_Palindrome_Number
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            if( x < 10 && x >= 0)
            {
                return true;
            }

            return x == RevertedNumber(x);
        }

        private static int RevertedNumber(int x)
        {
            var revertedNumber = 0;
            while (x > 0)
            {
                var lastDigit = x % 10;
                revertedNumber = revertedNumber * 10 + lastDigit;
                x /= 10;
            }
            return revertedNumber;
        }

        public static bool IsPalindromeSubstring(string s, int windowLow, int windowHigh)
        {

            if (s == null || windowLow > windowHigh || windowHigh >= s.Length)
                return false;

            bool isPalindrome = true;
            do
            {

                isPalindrome = isPalindrome && s[windowHigh] == s[windowLow];
                windowLow++;
                windowHigh--;
            }
            while (windowHigh > windowLow && isPalindrome);


            return isPalindrome;
        }
    }
}
