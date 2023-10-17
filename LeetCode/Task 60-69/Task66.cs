using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_60_69
{
    internal class Task66
    {
        public int[] PlusOne(int[] digits)
        {
            bool allNines = true;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != 9)
                {
                    allNines = false;
                    break;
                }
            }

            if (allNines)
            {
                int[] array = new int[digits.Length+1];
                array[0] = 1;
                return array;
            }


            for (int i=digits.Length-1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    break;
                }
                else
                {
                    digits[i] = 0;
                }
            }

            return digits;

        }
    }
}
