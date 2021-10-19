
namespace Leetcode.Problems
{
    public static class P5_Longest_Palindromic_Substring
    {
        public static string LongestPalindrome(string s)
        {
            int longestLength = 0;
            int windowLowBest = 0;


            for (int windowLow = 0; windowLow < s.Length; windowLow++)
            {
                for (int windowHigh = windowLow; windowHigh < s.Length; windowHigh++)
                {
                   
                    bool isPalindrome = IsPalindromeSubstring(s, windowLow, windowHigh);
                    if (isPalindrome)
                    {
                        int length = windowHigh - windowLow + 1;
                        if (length > longestLength)
                        {
                            longestLength = length;
                            windowLowBest = windowLow;
                        }



                    }
                }
            }

            return s.Substring(windowLowBest, longestLength);

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
            while ( windowHigh > windowLow && isPalindrome);


            return isPalindrome;
        }
    }
}
