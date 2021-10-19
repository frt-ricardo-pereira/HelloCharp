
using Xunit;
using Leetcode.Problems;
namespace HelloSharp.Test.Leetcode
{
    public class P7_Reverse_Integer_Tests
    {

        [Fact]
        public void Example1()
        {
            var input = 123;

            var actual = P7_Reverse_Integer.Reverse(input);

            var outputExpected = 321;
            Assert.Equal(outputExpected, actual);
        }
        [Fact]
        public void Example2()
        {
            var input = -123;

            var actual = P7_Reverse_Integer.Reverse(input);

            var outputExpected = -321;
            Assert.Equal(outputExpected, actual);

        }
        [Fact]
        public void Example3()
        {
            var input = 120;

            var actual = P7_Reverse_Integer.Reverse(input);

            var outputExpected = 21;
            Assert.Equal(outputExpected, actual);

        }

        [Fact]
        public void Example4()
        {
            var input = 0;

            var actual = P7_Reverse_Integer.Reverse(input);

            var outputExpected = 0;
            Assert.Equal(outputExpected, actual);

        }

        [Fact]
        public void Example5()
        {
            var input = 1534236469;

            var actual = P7_Reverse_Integer.Reverse(input);

            var outputExpected = 0;
            Assert.Equal(outputExpected, actual);

        }

    }
}
