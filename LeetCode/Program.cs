using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Task3 t = new Task3();
            //Console.WriteLine(t.LengthOfLongestSubstring("tmmzuxt"));
            //Console.WriteLine(t.LengthOfLongestSubstring("abcdbefgh"));
            //Console.WriteLine(t.LengthOfLongestSubstring("aabaab!bb"));
            //Console.WriteLine(t.LengthOfLongestSubstring2("tmmzuxt"));
            //Console.WriteLine(t.LengthOfLongestSubstring2("abcdbefgh"));
            //Console.WriteLine(t.LengthOfLongestSubstring("aabaab!bb"));

            t.LengthOfLongestSubstring("tmmzuxt");
            Console.WriteLine("---");

            t.LengthOfLongestSubstring("abcdbefgh");
            Console.WriteLine("---");

            t.LengthOfLongestSubstring("aabaab!bb");
            Console.WriteLine("---");
            t.LengthOfLongestSubstring("dvdf");

            Task4 tt = new Task4();

            Console.WriteLine(tt.FindMedianSortedArrays(new int[] { 1, 2 },new int[] { 3, 4 }));


        }
    }
}
