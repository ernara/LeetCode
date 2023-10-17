using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class Task61
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            List<int> values = new List<int>();

            while (head != null)
            {
                values.Add(head.val);
                head = head.next;
            }

            if (values.Count == 0)
            {
                return head;
            }

            values.Reverse();


            k %= values.Count;

            ListNode result = new ListNode(values[k]);

            for (int i = k+1; i < values.Count; i++)
            {
                result = new ListNode(values[i], result);
            }

            for (int i = 0; i < k; i++)
            {
                result = new ListNode(values[i], result);
            }

            return result;

        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
