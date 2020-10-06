using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Task2.ListNode k = new Task2.ListNode(0,new Task2.ListNode());

            k = new Task2.ListNode(k.next.val, k.next);
            k = new Task2.ListNode(k.next.val, k.next);
            k = new Task2.ListNode(k.next.val, k.next);
            k = new Task2.ListNode(k.next.val, k.next);

            if (k==null)
            {
                Console.WriteLine("lowqoeoq");
            }

            if (k.next == null)
            {
                Console.WriteLine("lol");
            }

            if (k.next.next == null)
            {
                Console.WriteLine("lolol");
            }

            Console.WriteLine($"object:{k} val:{k.val} next: {k.next} next.val: {k.next.val} next.next: {k.next.next}");
        }
    }
}
