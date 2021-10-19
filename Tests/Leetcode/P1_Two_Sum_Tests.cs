using Xunit;
using Leetcode.Problems;

namespace HelloSharp.Test.Leetcode
{
    public class P1_Two_Sum_Tests
    {
        [Fact]
        public void Example1()
        {
            int [] nums  = { 2, 7, 11 , 15 };
            int target = 9;
            
            var actual = P1_Two_Sum.SolutionON(nums, target) ;
            
            var outputExpected = new int[] { 0, 1 };
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example2()
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;        
            
            var actual = P1_Two_Sum.SolutionON(nums, target);

            var outputExpected = new int[] { 1, 2 };
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example3()
        {
            int[] nums = { 3, 3 };
            int target = 6;

            var outputExpected = new int[] { 0 ,1 };
            var actual = P1_Two_Sum.SolutionON(nums, target);

            Assert.Equal(outputExpected, actual);
        }
    }
}