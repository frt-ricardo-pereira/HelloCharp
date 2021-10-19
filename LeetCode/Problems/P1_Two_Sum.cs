

namespace Leetcode.Problems
{

    /**
     * https://leetcode.com/problems/two-sum/
     * You may assume that each input would have exactly one solution, and you may not use the same element twice.
     * */
    public static class P1_Two_Sum
    {

        public static int[] SolutionON(int[] nums, int target)
        {
            Dictionary<int, int> indices = new();
            indices.Add(nums[0] , 0); 
            for (int i = 1; i < nums.Length; i++)
            {
                var value = target - nums[i];
                if(indices.ContainsKey(value))
                {
                    var indice = indices[value];
                    return new int[] { indice , i};
                }
                if (!indices.ContainsKey(nums[i]))
                {
                    indices.Add(nums[i], i);
                }
            }

            return Array.Empty<int>();


        }
    }
}
