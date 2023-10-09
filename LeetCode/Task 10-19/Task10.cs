using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode
{
    class Task10
    {
        public bool IsMatch(string s, string p)
        {
            if (p.Length==2 && p[1]=='*' && p[0] == '.') { return true; }

            Console.WriteLine($"-------{s} {p}-------");
            int i = 0, y = 0;
            for (; i<s.Length && y<p.Length;)
            {
                
                if (y + 2 < p.Length && p[y] == '.' && p[y + 1] == '*')
                {
                    if (p[y + 2] != s[i])
                    {
                        i++;
                    }
                    else
                    {
                        i += 1;
                        y += 3;
                    }
                }
                else if (s[i] == p[y] || p[y]=='.')
                {
                    i++;
                    y++;
                }
                else if (y > 0 && p[y] == '*' &&  p[y - 1] == s[i])
                {
                    if (y+2<p.Length)
                    {
                        if (IsMatch(s.Substring(i), p.Substring(y + 1)))
                        {
                            return true;
                        }
                    }
                    i++;
                }
                else if (y+1<p.Length && p[y+1] == '*')
                {
                    y += 2;
                }
                else if (y > 0 && p[y] == '*' && p[y - 1] != s[i])
                {
                    y++;
                }
                else
                {
                    Console.WriteLine($"anksciau {i} {y}");
                    return false; 
                }
            }

            if (y < p.Length && p[y] == '*') { y++; }

            Console.WriteLine($"{i} {y}");
            if (i==s.Length && y ==p.Length)
            {
                return true;
            }
            return false;

        }

       
    }
}
