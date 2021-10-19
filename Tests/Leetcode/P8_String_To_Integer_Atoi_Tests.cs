

using Xunit;
using Leetcode.Problems;
namespace HelloSharp.Test.Leetcode
{
    public class P8_String_To_Integer_Atoi_Tests
    {
        [Fact]
        public void Example1()
        {
            var input = "42";

            var actual = P8_String_To_Integer_Atoi.MyAtoi(input);

            var outputExpected = 42;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example2()
        {
            var input = "      -42";

            var actual = P8_String_To_Integer_Atoi.MyAtoi(input);

            var outputExpected = -42;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example3()
        {
            var input = "4193 with words";

            var actual = P8_String_To_Integer_Atoi.MyAtoi(input);

            var outputExpected = 4193;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example4()
        {
            var input = "words and 987";

            var actual = P8_String_To_Integer_Atoi.MyAtoi(input);

            var outputExpected = 0;
            Assert.Equal(outputExpected, actual);
        }


        [Fact]
        public void Example5()
        {
            var input = "-91283472332";

            var actual = P8_String_To_Integer_Atoi.MyAtoi(input);

            var outputExpected = -2147483648;
            Assert.Equal(outputExpected, actual);
        }

      
        [Fact]
        public void Example6()
        {
            var input = "+-12";

            var actual = P8_String_To_Integer_Atoi.MyAtoi(input);

            var outputExpected = 0;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example7()
        {
            var input = "21474836460";

            var actual = P8_String_To_Integer_Atoi.MyAtoi(input);

            var outputExpected = 2147483647;
            Assert.Equal(outputExpected, actual);


        }

        [Fact]
        public void Example9()
        {
            var input = "00000-42a1234";

            var actual = P8_String_To_Integer_Atoi.MyAtoi(input);

            var outputExpected = 0;
            Assert.Equal(outputExpected, actual);


        }


        [Fact]
        public void Example10()
        {
            var input = "-10-";

            var actual = P8_String_To_Integer_Atoi.MyAtoi(input);

            var outputExpected = -10;
            Assert.Equal(outputExpected, actual);


        }


    }
}
