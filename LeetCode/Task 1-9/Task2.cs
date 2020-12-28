using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> list = new List<int>();
            int more = (l1.val + l2.val) / 10;
            int values = (l1.val + l2.val) % 10;

            list.Add(values);

            l1 = l1.next;
            l2 = l2.next;

            while (l1!=null && l2!=null)
            {
                values = (l1.val + l2.val + more) % 10;
                more = (l1.val + l2.val + more) / 10;

                list.Add(values);

                l1 = l1.next;
                l2 = l2.next;
            }

            while (l1!=null)
            {
                values = (l1.val + more) % 10;
                more = (l1.val + more) / 10;

                list.Add(values);

                l1 = l1.next;
            }

            while (l2 != null)
            {
                values = (l2.val + more) % 10;
                more = (l2.val + more) / 10;
                list.Add(values);
                l2 = l2.next;
            }

            if (more>0)
            {
                list.Add(more);
            }

            list.Reverse();

            ListNode l3 = new ListNode(list[0], null);
            for (int i=1;i<list.Count;i++)
            {
                l3 = new ListNode(list[i],l3);
            }

            return l3;
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
