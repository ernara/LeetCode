using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_70_79
{
    internal class Task73
    {
        public void SetZeroes(int[][] matrix)
        {
            List<int> ints = new List<int>();
            List<int> ynts = new List<int>();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int y = 0; y < matrix[i].Length; y++)
                {
                    if (matrix[i][y] == 0)
                    {
                        ints.Add(i);
                        ynts.Add(y);
                    }
                }
            }

            for (int i = 0; i < ints.Count; i++)
            {
                for (int y = 0; y < matrix[ints[i]].Length; y++)
                {
                    matrix[ints[i]][y] = 0;
                }
                for (int y = 0; y < matrix.Length; y++)
                {
                    matrix[y][ynts[i]] = 0;
                }
            }
        }
    }
}
