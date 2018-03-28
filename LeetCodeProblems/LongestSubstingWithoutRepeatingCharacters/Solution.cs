using System;

namespace LeetCodeProblems.LongestSubstingWithoutRepeatingCharacters
{
    /// <summary>
    /// Solution to 3. Longest Substring Without Repeating Characters
    /// <a href="https://leetcode.com/problems/longest-substring-without-repeating-characters/description/">Link</a>
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Finds the length of the longest substring without repeated characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            string substring = ""; // temp string holding current substring
            int length = 0;

            foreach (char c in s)
            {
                if (substring.Contains(c.ToString()))
                {
                    //substring = substring.IndexOf(c) == 0 ? substring.Substring(1) + c : substring.Substring(substring.IndexOf(c));
                    substring = substring.Substring(substring.IndexOf(c) + 1) + c;
                }
                else
                {
                    substring += c;
                }
                length = Math.Max(length, substring.Length);
            }

            return length;
        }

        /// <summary>
        /// Run test cases to Longest Substring Without Repeating Characters Problem
        /// </summary>
        public static void Run()
        {
            Solution s = new Solution();
            Console.WriteLine(s.LengthOfLongestSubstring("abcedctesf"));
            Console.WriteLine(s.LengthOfLongestSubstring("bpfbhmipx"));
            Console.WriteLine(s.LengthOfLongestSubstring(""));
            Console.WriteLine(s.LengthOfLongestSubstring("a"));
            Console.WriteLine(s.LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(s.LengthOfLongestSubstring("bbbbb"));
            Console.WriteLine(s.LengthOfLongestSubstring("pwwkew"));
            Console.WriteLine(s.LengthOfLongestSubstring("aab"));
            Console.WriteLine(s.LengthOfLongestSubstring("abb"));
            Console.WriteLine(s.LengthOfLongestSubstring("aba"));
        }
    }
}
