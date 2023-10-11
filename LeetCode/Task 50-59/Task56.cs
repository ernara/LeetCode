using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_50_59
{
    internal class Task56
    {
        class ArrayComparer : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                if (x[0] < y[0])
                    return -1;
                if (x[0] > y[0])
                    return 1;
                return 0;
            }
        }
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length < 2)
            {
                return intervals;
            }

            Array.Sort(intervals, new ArrayComparer());

            int[][] newIntervals = new int[intervals.Length + 1][];

            Array.Copy(intervals, newIntervals, intervals.Length);

            newIntervals[intervals.Length] = new int[] { -1, -1 };

            intervals = newIntervals;

            List<List<int>> list = new List<List<int>>();
            list.Add(new List<int>() { intervals[0][0], intervals[0][1] });

            for (int i=0; i < intervals.Length-1;i++)
            {
                if ((list[list.Count - 1][0] >= intervals[i + 1][0] && list[list.Count - 1][0] <= intervals[i + 1][1]) || (list[list.Count - 1][1] >= intervals[i + 1][0] && list[list.Count - 1][1] <= intervals[i + 1][1]))
                {
                    list[list.Count - 1][0] = Math.Min(list[list.Count - 1][0], intervals[i + 1][0]);
                    list[list.Count - 1][1] = Math.Max(list[list.Count - 1][1], intervals[i + 1][1]);
                }

                else if (intervals[i + 1][0] > list[list.Count - 1][1])
                {
                    list.Add(new List<int>() { intervals[i + 1][0], intervals[i + 1][1] });
                }
            }

            return ConvertToArray(list);
        }

        public int[][] ConvertToArray(List<List<int>> list)
        {
            int[][] jaggedArray = new int[list.Count][];

            for (int i = 0; i < list.Count; i++)
            {
                jaggedArray[i] = list[i].ToArray();
            }

            return jaggedArray;
        }
    }
}
