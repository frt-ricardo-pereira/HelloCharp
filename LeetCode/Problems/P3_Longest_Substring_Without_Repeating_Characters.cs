using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /**
   * https://leetcode.com/problems/longest-substring-without-repeating-characters//
   * You may assume that each input would have exactly one solution, and you may not use the same element twice.
   * */
    public static class P3_Longest_Substring_Without_Repeating_Characters
    {


        public static int SolutionON(string s)
        {
            int currentCount = 0;
            int MaxCount = 0;
            int windowLow = 0;
            Dictionary<char, int> memory = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                var currentLetter = s[i];
             
                if (memory.ContainsKey(currentLetter) && windowLow <= memory[currentLetter])
                {
                    int indexLastLetter = memory[currentLetter];
                    windowLow = indexLastLetter + 1;
          
                }
                memory[currentLetter] = i;
                currentCount = i - windowLow + 1;
                MaxCount = Math.Max(MaxCount, currentCount);
            }

            return MaxCount;
        }



        public static int SolutionON2(string s)
        {
            int currentCount = 0;
            int MaxCount = 0;
            int windowLow = 0;
            Dictionary<char, int> memory = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                var currentLetter = s[i];
                if (memory.ContainsKey(currentLetter) && windowLow <= memory[currentLetter])
                {
                    int indexLastLetter = memory[currentLetter];
                    windowLow = indexLastLetter + 1;
                    currentCount = i - windowLow + 1;
                    memory[currentLetter] = i;

                }
                else
                {
                    memory[currentLetter] = i;
                    currentCount++;
                }

                MaxCount = Math.Max(MaxCount, currentCount);
            }

            return MaxCount;
        }
    }
}
