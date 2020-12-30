using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Task11 task11 = new Task11();
            Console.WriteLine(task11.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
            Console.WriteLine(task11.MaxArea(new int[] { 4, 3, 2, 1, 4 }));
            
        }
    }
}
