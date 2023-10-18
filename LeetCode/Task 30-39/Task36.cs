using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_30_39
{
    internal class Task36
    {
        public bool IsValidSudoku(char[][] board)
        {
            for(int i=0;i<9;i++)
            {
                HashSet <int> h1 = new HashSet<int>();
                HashSet <int> h2 = new HashSet<int>();
                for (int y = 0; y < 9;y++)
                {
                    if (h1.Contains(board[i][y]) && char.IsDigit(board[i][y]))
                    {
                        return false;
                    }
                    if (h2.Contains(board[y][i]) && char.IsDigit(board[y][i]))
                    {
                        return false;
                    }
                    
                    h1.Add(board[i][y]);
                    h2.Add(board[y][i]);
                }
            }
            return true;
        }
    }
}
