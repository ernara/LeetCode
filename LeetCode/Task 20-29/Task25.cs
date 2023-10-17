using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_20_29
{
    internal class Task25
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode first = head;

            List<ListNode> lists = new();

            while (first != null)
            {
                lists.Add(first);

                if (lists.Count == k)
                {
                    for (int i = 0; i < lists.Count / 2; i++)
                    {
                        (lists[i].val, lists[k - i - 1].val) = (lists[k - i - 1].val, lists[i].val);
                    }
                    lists.Clear();
                }

                first = first.next;
            }

            return head;
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
