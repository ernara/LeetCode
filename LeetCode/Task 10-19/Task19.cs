using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            List<int> list = new List<int>();

            int i = 0;

            while (head!=null)
            {
                list.Add(head.val);
                head = head.next;
            }

            list.RemoveAt(n);
            list.Reverse();

            return newNode;
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
