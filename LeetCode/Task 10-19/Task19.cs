using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode newNode = new ListNode(head.val);
            ListNode oldNode = head.next;

            int i = 0;

            for (ListNode currentNew = newNode; oldNode != null; oldNode = oldNode.next, currentNew = currentNew.next,i++)
            {
                if (i != n)
                {
                    Console.WriteLine(oldNode.val + " " + i);
                    
                }
                currentNew.next = new ListNode(oldNode.val);
            }
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
