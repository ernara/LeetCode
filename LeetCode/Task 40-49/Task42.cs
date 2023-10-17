using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task42
    {
        public int Trap(int[] height)
        {
            int water = 0;
            for (int i=0;i<height.Length-1; i++) 
            {
                if (height[i] > 0)
                {
                    int boarder = 0;
                    int bbi = i+1;
                    for (int y=i+1;y<height.Length;y++)
                    {
                        if (height[y]>boarder)
                        {
                            boarder = height[y];
                            bbi = y;
                        }
                        if (boarder >= height[i])
                        {
                            break;
                        }
                    }
                    boarder=Math.Min(boarder, height[i]);
                    for (int y = i + 1; y < bbi; y++)
                    {
                        if (boarder - height[y]>0)
                        {
                            water += (boarder - height[y]);
                        }
                    }
                    i = bbi - 1;
                }
            }
            return water;
        }

    }
}
