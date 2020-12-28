using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task6
    {
        public string Convert(string s, int numRows)
        {
            if (numRows==1)
            {
                return s;
            }

            string[] array = new string[numRows];
            int arrow = 0;
            int number = -1;
            numRows--;

            for (int i=0;i<s.Length;i++)
            {
                array[arrow] += s[i];
                if (arrow==0 || arrow==numRows)
                {
                    if (number==-1)
                    {
                        number = 1;
                    }
                    else
                    {
                        number = -1;
                    }
                }
                arrow += number;
            }

            return string.Join("",array);
        }
    }
}
