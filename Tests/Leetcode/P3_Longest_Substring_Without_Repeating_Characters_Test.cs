using Leetcode.Problems;
using Xunit;

namespace HelloSharp.Test.Leetcode
{
    public class Longest_Substring_Without_Repeating_Characters_Test
    {
        [Fact]
        public void Example1()
        {
            string word = "abcabcbb";

            var actual = P3_Longest_Substring_Without_Repeating_Characters.SolutionON(word);

            var outputExpected = 3;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example2()
        {
            string word = "bbbbb";

            var actual = P3_Longest_Substring_Without_Repeating_Characters.SolutionON(word);

            var outputExpected = 1;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example3()
        {
            string word = "pwwkew";

            var actual = P3_Longest_Substring_Without_Repeating_Characters.SolutionON(word);

            var outputExpected = 3;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example4()
        {
            string word = "";

            var actual = P3_Longest_Substring_Without_Repeating_Characters.SolutionON(word);

            var outputExpected = 0;
            Assert.Equal(outputExpected, actual);
        }
        [Fact]
        public void Example5()
        {
            string word = "aab";

            var actual = P3_Longest_Substring_Without_Repeating_Characters.SolutionON(word);

            var outputExpected = 2;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example6()
        {
            string word = "dvdf";

            var actual = P3_Longest_Substring_Without_Repeating_Characters.SolutionON(word);

            var outputExpected = 3;
            Assert.Equal(outputExpected, actual);
        }
        [Fact]
        public void Example7()
        {
            string word = "abba";

            var actual = P3_Longest_Substring_Without_Repeating_Characters.SolutionON(word);

            var outputExpected = 2;
            Assert.Equal(outputExpected, actual);
        }
        [Fact]
        public void Example8()
        {
            string word = "aabaab!bb";

            var actual = P3_Longest_Substring_Without_Repeating_Characters.SolutionON(word);

            var outputExpected = 3;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example9()
        {
            string word = "bbtablud";

            var actual = P3_Longest_Substring_Without_Repeating_Characters.SolutionON(word);

            var outputExpected = 6;
            Assert.Equal(outputExpected, actual);
        }

    }
}
