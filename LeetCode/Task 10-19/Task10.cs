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
            if (s.Length == 0 && p.Length == 0)
            {
                return true;
            }
            else if (s.Length!=0 && p.Length==0)
            {
                return false;
            }
            else if (1<p.Length && p[1]=='*')
            {
                if (IsMatch(s,p.Substring(2)))
                {
                    return true;
                }
                else 
                {
                    string copy = s;
                    string substring = p.Substring(2);
                    while (copy.Length > 0 && (p[0] == copy[0] || p[0] == '.'))
                    {
                        copy = copy.Substring(1);
                        if (IsMatch(copy, substring))
                        {
                            return true;
                        }
                    }
                }
            }
            else if (s.Length==0 && p.Length!=0)
            {
                return false; //istrinti?
            }
            else if (p[0]=='.')
            {
                if (IsMatch(s.Substring(1), p.Substring(1)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (s[0] == p[0])
            {
                if (IsMatch(s.Substring(1), p.Substring(1)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            return false;
        }

       
    }
}
