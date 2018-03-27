using LeetCodeProblems.MergeTwoSortedLists;

namespace LeetCodeProblems.Run
{
    /// <summary>
    /// <a href="https://leetcode.com/problems/add-two-numbers/description/">Merge two sorted lists</a>
    /// </summary>
    public class MergeTwoSortedLists
    {
        /// <summary>
        /// Run test solution
        /// </summary>
        public static void Run()
        {
            ListNode l1 = new ListNode(9);
            l1.next = new ListNode(9);
            //l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(1);
            //l2.next = new ListNode(9);
            //l2.next.next = new ListNode(4);

            ListNode ans = new Solution().AddTwoNumbers(l1, l2);
        }

    }
}
