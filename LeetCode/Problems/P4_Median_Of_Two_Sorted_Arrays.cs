
namespace Leetcode.Problems
{
    public static class P4_Median_Of_Two_Sorted_Arrays
    {
        /**
         * https://leetcode.com/problems/median-of-two-sorted-arrays/
         * */

        public static double FindMedianSortedArraysON(int[] nums1, int[] nums2)
        {
            int[] newArray = Add2Arrays(nums1, nums2);
            return CalculateMedianGivenArray(newArray);
        }

        public static int[] Add2Arrays(int[] nums1, int[] nums2)
        {
            int currentXNum1 = 0;
            int currentXNum2 = 0;
            int[] newArray = new int[nums1.Length + nums2.Length];
            int i = 0;
            while (i < newArray.Length)
            {

                int num1Value = currentXNum1 >= nums1.Length ? 0 : nums1[currentXNum1];
                int num2Value = currentXNum2 >= nums2.Length ? 0 : nums2[currentXNum2];
                if (currentXNum1 < nums1.Length && (num1Value < num2Value) || currentXNum2 >= nums2.Length)  
                {
                    newArray[i] = num1Value;
                    currentXNum1++;
                }
                else
                {
                    newArray[i] = num2Value;
                    currentXNum2++;
                }
                i++;
            }

            return newArray;
        }

        public static double CalculateMedianGivenArray(int[] newArray)
        {
            int length = newArray.Length;
            if (newArray == null || length == 0)
                return 0;
        
            return length % 2 == 1 ? newArray[length / 2]  : ((double) newArray[length / 2 - 1] + newArray[length / 2]) / 2;

        }
    }
}
