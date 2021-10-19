

using Xunit;
using Leetcode.Problems;

namespace HelloSharp.Test.Leetcode
{
    public class P9_Palindrome_Number_Tests
    {

        [Fact]
        public void Example1()
        {

            var input = 121;

            var actual = P9_Palindrome_Number.IsPalindrome(input);

            var outputExpected = true;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example2()
        {

            var input = -121;

            var actual = P9_Palindrome_Number.IsPalindrome(input);

            var outputExpected = false;
            Assert.Equal(outputExpected, actual);
        }


        [Fact]
        public void Example3()
        {

            var input = 10;

            var actual = P9_Palindrome_Number.IsPalindrome(input);

            var outputExpected = false;
            Assert.Equal(outputExpected, actual);
        }


        [Fact]
        public void Example5()
        {

            var input = 1221;

            var actual = P9_Palindrome_Number.IsPalindrome(input);

            var outputExpected = true;
            Assert.Equal(outputExpected, actual);
        }
    }
}
