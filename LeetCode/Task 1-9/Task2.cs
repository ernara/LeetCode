using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /*You are given two non-empty linked lists representing two non-negative integers. 
    The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
    You may assume the two numbers do not contain any leading zero, except the number 0 itself. 
    
    Constraints:

    The number of nodes in each linked list is in the range [1, 100].
    0 <= Node.val <= 9
    It is guaranteed that the list represents a number that does not have leading zeros.*/
    class Task2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //list to collect needed values 
            List<int> list = new List<int>();
            //residue
            int more = (l1.val + l2.val) / 10;
            //value to add
            int values = (l1.val + l2.val) % 10;

            list.Add(values);

            l1 = l1.next;
            l2 = l2.next;

            //go threw both nodes until one is empty
            while (l1!=null && l2!=null)
            {
                values = (l1.val + l2.val + more) % 10;
                more = (l1.val + l2.val + more) / 10;

                list.Add(values);

                l1 = l1.next;
                l2 = l2.next;
            }

            //go threw l1 node until it is empty
            while (l1!=null)
            {
                values = (l1.val + more) % 10;
                more = (l1.val + more) / 10;

                list.Add(values);

                l1 = l1.next;
            }

            //go threw l2 node until it is empty
            while (l2 != null)
            {
                values = (l2.val + more) % 10;
                more = (l2.val + more) / 10;
                list.Add(values);
                l2 = l2.next;
            }

            //check if residue has value bigger then 0. If has then add one more value
            if (more>0)
            {
                list.Add(more);
            }

            //need to reverse values because task says that digits are stored in reverse order
            list.Reverse();

            //adding list values to new ListNode
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
