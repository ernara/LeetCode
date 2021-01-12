using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_20_29
{
    class Task21
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            while (l1!=null && l2!=null)
            {
                if (l1.val<l2.val)
                {
                    result = new ListNode(l1.val, result);
                    l1 = l1.next;
                }
                else
                {
                    result = new ListNode(l2.val, result);
                    l2 = l2.next;
                }
            }

            while (l1 != null)
            {
                result = new ListNode(l1.val, result);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                result = new ListNode(l2.val, result);
                l2 = l2.next;
            }

            ListNode result2 = new ListNode(result.val, result);
            result = result.next;

            while (result!=null)
            {
                result2 = new ListNode(result.val, result2);
                result = result.next;
            }

            return result2;
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
