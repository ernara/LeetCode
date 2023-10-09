using System;
using LeetCode.Task_30_39;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Task42 task = new Task42();

            Console.WriteLine("----------");
            Console.WriteLine(task.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));

            Console.WriteLine("----------");
            Console.WriteLine(task.Trap(new int[] { 3, 0, 3, 0, 3, 0, 3 }));

            Console.WriteLine("----------");
            Console.WriteLine(task.Trap(new int[] { 4, 2, 3 }));

            Console.WriteLine("----------");
            Console.WriteLine(task.Trap(new int[] { 5, 4, 2, 3, 2, 4, 5 }));

            Console.WriteLine("----------");
            Console.WriteLine(task.Trap(new int[] { 5, 2, 4, 5, 1, 3 }));

            Console.WriteLine("----------");
            Console.WriteLine(task.Trap(new int[] { 5, 4, 3, 7, 6, 5, 4, 3, 2, 1 }));


        }
    }
}
