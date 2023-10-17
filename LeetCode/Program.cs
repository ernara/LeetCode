using System;
using LeetCode.Task_30_39;
using System.Collections.Generic;
using LeetCode.Task_50_59;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2009 task2009 = new Task2009();
            //Console.WriteLine($"{task2009.MinOperations(new int[] { 4, 2, 5, 3 })} {0}");
            //Console.WriteLine($"{task2009.MinOperations(new int[] { 1, 2, 3, 5, 6 })} {1}");
            //Console.WriteLine($"{task2009.MinOperations(new int[] { 1, 10, 100, 1000 })} {3}");
            //Console.WriteLine($"{task2009.MinOperations(new int[] { 41, 33, 29, 33, 35, 26, 47, 24, 18, 28 })} {5}");
            //Console.WriteLine($"{task2009.MinOperations(new int[] { 5, 5 })} {1}");

            Task56 task56 = new Task56();

            int[][] array = new int[2][];
            array[0] = new int[2] { 0, 4 };
            array[1] = new int[2] { 0, 1 };
            //Console.WriteLine($"{task56.Merge(array)}");

            //array = new int[2][];
            //array[0] = new int[2] { 0, 4 };
            //array[1] = new int[2] { 0, 1 };
            //Console.WriteLine($"{task56.Merge(array)}");

            //int[] a = new int[] { 1, 2, 3, 4, 5, 6, };
            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, };
            //int index = list.BinarySearch(5);
            //Console.WriteLine(index);

            Task44 task44 = new Task44();
            Console.WriteLine($"{task44.IsMatch("ss", "pp")} {false}");
            Console.WriteLine($"{task44.IsMatch("ss", "??")} {true}");
            Console.WriteLine($"{task44.IsMatch("ss", "**")} {true}");
            Console.WriteLine($"{task44.IsMatch("ss", "*")} {true}");
            Console.WriteLine($"{task44.IsMatch("ss", "?")} {false}");
            Console.WriteLine($"{task44.IsMatch("ss", "***")} {true}");
            Console.WriteLine($"{task44.IsMatch("ss", "???")} {false}");


        }
    }
}
