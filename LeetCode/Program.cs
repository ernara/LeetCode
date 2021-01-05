using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Task17 task = new Task17();
            var v = task.LetterCombinations("");

            foreach (var item in v)
            {
                Console.WriteLine(item);
            }
        }
    }
}
