using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Task14 task14 = new Task14();
            Console.WriteLine(task14.LongestCommonPrefix(new string[3] {"flower", "flow", "flight" }));
            Console.WriteLine(task14.LongestCommonPrefix(new string[1] { "" }));
            Console.WriteLine(task14.LongestCommonPrefix(new string[2] { "","" }));
            Console.WriteLine(task14.LongestCommonPrefix(new string[1] { "a" }));
            Console.WriteLine(task14.LongestCommonPrefix(new string[2] { "", "b" })); 
            Console.WriteLine(task14.LongestCommonPrefix(new string[2] { "a", "cc" })); 

        }
    }
}
