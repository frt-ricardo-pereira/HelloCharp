
using Xunit;
using Leetcode.Problems;
namespace HelloSharp.Test.Leetcode.Models
{
    public class P4_Median_Of_Two_Sorted_Arrays_Tests
    {
        [Fact]
        public void Example1()
        {
            int[] nums1 = { 1 , 3 };
            int[] nums2 = { 2 };

            var actual = P4_Median_Of_Two_Sorted_Arrays.FindMedianSortedArraysON(nums1, nums2);

            var outputExpected = 2;
            Assert.Equal(outputExpected , actual);
        }

        [Fact]
        public void Example2()
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3 , 4 };

            var actual = P4_Median_Of_Two_Sorted_Arrays.FindMedianSortedArraysON(nums1, nums2);

            var outputExpected = 2.5;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example3()
        {
            int[] nums1 = { 0, 0 };
            int[] nums2 = { 0, 0 };

            var actual = P4_Median_Of_Two_Sorted_Arrays.FindMedianSortedArraysON(nums1, nums2);

            var outputExpected = 0;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example4()
        {
            int[] nums1 = {  };
            int[] nums2 = { 1 };

            var actual = P4_Median_Of_Two_Sorted_Arrays.FindMedianSortedArraysON(nums1, nums2);

            var outputExpected = 1;
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example5()
        {
            int[] nums1 = { 2};
            int[] nums2 = {  };

            var actual = P4_Median_Of_Two_Sorted_Arrays.FindMedianSortedArraysON(nums1, nums2);

            var outputExpected = 2;
            Assert.Equal(outputExpected, actual);
        }


        [Fact]
        public void Example1_Add2Arrays()
        {
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };

            var actual = P4_Median_Of_Two_Sorted_Arrays.Add2Arrays(nums1, nums2);

            var outputExpected = new int [] {1,2,3};
            Assert.Equal(outputExpected, actual);
        }


        [Fact]
        public void Example2_Add2Arrays()
        {
            int[] nums1 = { 1, 2};
            int[] nums2 = { 3 , 4 };

            var actual = P4_Median_Of_Two_Sorted_Arrays.Add2Arrays(nums1, nums2);

            var outputExpected = new int[] { 1, 2, 3 ,4  };
            Assert.Equal(outputExpected, actual);
        }

        [Fact]
        public void Example3_Add2Arrays()
        {
            int[] nums1 = { 0 , 0 };
            int[] nums2 = { 0 , 0 };

            var actual = P4_Median_Of_Two_Sorted_Arrays.Add2Arrays(nums1, nums2);

            var outputExpected = new int[] { 0 , 0 , 0 ,0 };
            Assert.Equal(outputExpected, actual);
        }


        [Fact]
        public void Example4_Add2Arrays()
        {
            int[] nums1 = {  };
            int[] nums2 = {  1};

            var actual = P4_Median_Of_Two_Sorted_Arrays.Add2Arrays(nums1, nums2);

            var outputExpected = new int[] {1  };
            Assert.Equal(outputExpected, actual);
        }
        [Fact]
        public void Example5_Add2Arrays()
        {
            int[] nums1 = { 2};
            int[] nums2 = {  };

            var actual = P4_Median_Of_Two_Sorted_Arrays.Add2Arrays(nums1, nums2);

            var outputExpected = new int[] { 2 };
            Assert.Equal(outputExpected, actual);
        }
    }
}
