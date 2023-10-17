using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_20_29
{
    internal class Task23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            List<int> values = new List<int>();

            for (int i = 0; i < lists.Length; i++)
            {
                while (lists[i] != null)
                {
                    values.Add(lists[i].val);
                    lists[i] = lists[i].next;
                }
            }

            Console.WriteLine(values.Count);
            if (values.Count == 0) { return new ListNode().next; }

            values.Sort();

            ListNode result = new ListNode(values[values.Count - 1]);

            for (int i = values.Count - 2; i >= 0; i--)
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
