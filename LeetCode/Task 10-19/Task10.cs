using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task10
    {
        public bool IsMatch(string s, string p)
        {
            int y = 0;

            char same;

            for (int i=0;i<p.Length && y<s.Length;i++)
            {
                if (p[i]=='.')
                {
                    same = s[y];
                }
                else
                {
                    same = p[i];
                }

                if (i + 1 < p.Length && p[i + 1] == '*')
                {
                    while (y < p.Length && s[y] == same)
                    {
                        y++;
                    }
                }
                else
                {
                    if (s[y] == same)
                    {
                        y++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (y==s.Length)
            {
                return true;
            }
            return false;
        }
    }
}
