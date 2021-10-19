using Xunit;
using Leetcode.Problems;
namespace HelloSharp.Test.Leetcode
{
    public class P5_Longest_Palindromic_Substring_Tests
    {

        [Fact]
        public void Example1()
        {
            string input = "babad";

            var actual = P5_Longest_Palindromic_Substring.LongestPalindrome(input);

            var outputExpected = "bab";
            Assert.Equal(outputExpected, actual);
        }


        [Fact]
        public void Example2()
        {
            string input = "cbbd";

            var actual = P5_Longest_Palindromic_Substring.LongestPalindrome(input);

            var outputExpected = "bb";
            Assert.Equal(outputExpected, actual);
        }



        [Fact]
        public void Example3()
        {
            string input = "a";

            var actual = P5_Longest_Palindromic_Substring.LongestPalindrome(input);

            var outputExpected = "a";
            Assert.Equal(outputExpected, actual);
        }



        [Fact]
        public void Example4()
        {
            string input = "ac";

            var actual = P5_Longest_Palindromic_Substring.LongestPalindrome(input);

            var outputExpected = "a";
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void IsPolindrome1()
        {

            string input = "babad";

            var actual = P5_Longest_Palindromic_Substring.IsPalindromeSubstring(input , 0 , 2);

            var outputExpected = true;
            Assert.Equal(outputExpected, actual);

        }
        [Fact]
        public void IsPolindrome2()
        {

            string input = "babad";

            var actual = P5_Longest_Palindromic_Substring.IsPalindromeSubstring(input, 0, 2);

            var outputExpected = true;
            Assert.Equal(outputExpected, actual);

        }

        [Fact]
        public void IsPolindrome3()
        {

            string input = "cbbd";

            var actual = P5_Longest_Palindromic_Substring.IsPalindromeSubstring(input, 1  , 2);

            var outputExpected = true;
            Assert.Equal(outputExpected, actual);

        }
    }
}
