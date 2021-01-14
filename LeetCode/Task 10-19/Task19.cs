using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null || head.next == null)
                return head.next;

            List<int> list = new List<int>();

            while (head!=null)
            {
                list.Add(head.val);
                head = head.next;
            }

            list.Reverse();
            list.RemoveAt(--n);

            ListNode result = new ListNode(list[0]);

            for (int i=1;i<list.Count;i++)
            {
                result = new ListNode(list[i], result);
            }

            return result;
        }
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
