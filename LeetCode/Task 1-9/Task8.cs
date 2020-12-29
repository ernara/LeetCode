using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task8
    {
        public int MyAtoi(string s)
        {
            string number = "";

            int i = 0;

            while (i<s.Length)
            {
                if (s[i] != ' ')
                {
                    if (s[i] == '+')
                    {
                        i++;

                    }
                    else if (s[i] == '-')
                    {
                        number += "-";
                        i++;

                    }
                    else if (!Char.IsDigit(s[i]))
                    {
                        return 0;
                    }
                    while (i<s.Length && Char.IsDigit(s[i]))
                    {
                        number += s[i];
                        i++;
                    }

                    break;
                }
                i++;
            }

            if (number.Length==0)
            {
                return 0;
            }
            if (number.Length==1 && number=="-")
            {
                return 0;
            }

            try
            {
                return int.Parse(number);
            }
            catch(OverflowException)
            {
                if (number[0] == '-')
                {
                    return int.MinValue;
                }
                return int.MaxValue;
            }

        }
    }
}
