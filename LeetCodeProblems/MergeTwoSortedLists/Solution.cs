namespace LeetCodeProblems.MergeTwoSortedLists
{
    /// <summary>
    /// Solution to Merging two sorted lists
    /// <a href="https://leetcode.com/problems/add-two-numbers/description/">Link to LeetCode</a>
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Add two numbers represented by linked lists.
        /// Digits are stored in reverse order and each node contains a single digit.
        /// </summary>
        /// <param name="l1">Starting node of first number</param>
        /// <param name="l2">Starting node of second number</param>
        /// <returns>Starting node of result</returns>
        /// <remarks>Created by Gerardo</remarks>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sum; // sum of two nodes
            int carry;
            ListNode listNode;

            sum = l1.val + l2.val;
            listNode = new ListNode(sum % 10);
            carry = sum / 10; //Handle carry from summing two numbers

            if (carry != 0)
            {
                if (l1.next == null)
                {
                    l1.next = new ListNode(carry);
                }
                else
                {
                    l1.next.val += carry;
                }
            }
            if (l1.next == null && l2.next == null)
            {
                return listNode;
            }
            else if (l1.next == null)
            {
                listNode.next = AddTwoNumbers(new ListNode(0), l2.next);
                return listNode;
            }
            else if (l2.next == null)
            {
                listNode.next = AddTwoNumbers(l1.next, new ListNode(0));
                return listNode;
            }
            else
            {
                listNode.next = AddTwoNumbers(l1.next, l2.next);
                return listNode;
            }
        }

        /// <summary>
        /// Add two numbers represented by linked lists.
        /// Digits are stored in reverse order and each node contains a single digit.
        /// </summary>
        /// <param name="l1">Starting node of first number</param>
        /// <param name="l2">Starting node of second number</param>
        /// <returns>Starting node of result</returns>
        /// <remarks>Suggested solution from <a href="https://leetcode.com/problems/add-two-numbers/description/">LeetCode</a> </remarks>
        public ListNode AddTwoNumbersLeetCode(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0); // Dummy node not returned
            ListNode current;
            int carry = 0; //Note carray with be either 0 or 1

            ListNode p = l1;
            ListNode q = l2;
            current = dummyHead; // pointer to dummyHead

            while (p != null || q != null)
            {
                int x = p != null ? p.val : 0;
                int y = q != null ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;
                if (p != null)
                {
                    p = p.next;
                }
                if (q != null)
                {
                    q = q.next;
                }
            }
            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }
            return dummyHead.next;
        }

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

            ListNode ans = new Solution().AddTwoNumbersLeetCode(l1, l2);
        }
    }
}
