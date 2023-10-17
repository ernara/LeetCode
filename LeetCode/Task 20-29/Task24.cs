using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace LeetCode.Task_20_29
{
    internal class Task24
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode first = head;
            ListNode second = head;

            while (first!=null && first.next!=null)
            {
                second = first.next;
                (first.val,second.val) = (second.val,first.val);
                first = second.next;
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
