using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task12
    {
        public string IntToRoman(int num)
        {
            List<int> normalNumbers = new List<int>() {   1,   5,   10, 50,  100, 500, 1000 };
            List<char> romanNumbers = new List<char>() { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };

            string s = "";

            for (int i=normalNumbers.Count-1;i>=0;i--)
            {
                if(num>=normalNumbers[i])
                {
                    if (i % 2 == 0)
                    {
                        if(num / normalNumbers[i] >= 4)
                        {
                            s += romanNumbers[i];
                            s += romanNumbers[i + 1];
                            num += normalNumbers[i];
                            num -= normalNumbers[i + 1];
                        }
                        else
                        {
                            while (num >= normalNumbers[i])
                            {
                                s += romanNumbers[i];
                                num -= normalNumbers[i];
                            }
                        }
                    }
                    else
                    {
                        if (i > 0 && i + 1 < normalNumbers.Count && num >= -normalNumbers[i - 1] + normalNumbers[i + 1])
                        {
                            s += romanNumbers[i - 1];
                            s += romanNumbers[i + 1];
                            num += normalNumbers[i - 1];
                            num -= normalNumbers[i + 1];
                        }
                        else
                        {
                            s += romanNumbers[i];
                            num -= normalNumbers[i];
                        }
                    }
                }
            }

            return s;
        }
    }
}
