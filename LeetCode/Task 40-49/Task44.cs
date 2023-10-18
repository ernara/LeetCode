//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace LeetCode
//{
//    internal class Task44
//    {
//        public bool IsMatch(string s, string p)
//        {
//            Console.WriteLine($"{s.Length} {p.Length}");
//            for(int i=0; i<p.Length-1; i++)
//            {
//                if (p[i]=='*' && p[i+1]=='*')
//                {
//                    p=p.Remove(i+1,1);
//                    i--;
//                }
//            }

//            for (int i = 0; i < s.Length && i<p.Length && s.Length< p.Length`; i++)
//            {
//                if (p[i] == '*')
//                {
//                    if(i + 1 < p.Length && i + 1 < s.Length)
//                    {
                        
//                        while (s[i] != p[i + 1] || p[i+1] == '?')
//                        {
//                            s = s.Remove(i, 1);
//                        }
//                        p = p.Remove(i, 1);
//                    }
//                }
//                else if (p[i]=='?' || p[i] == s[i])
//                {
//                    p = p.Remove(i, 1);
//                    s = s.Remove(i, 1);
//                    i--;
//                }
//                else
//                {
//                    break;
//                }
//            }

//            Console.WriteLine($"{s} {s.Length}");
//            Console.WriteLine($"{p} {p.Length}");


//            return IsMatch2(s, p);
//        }

//        public bool IsMatch2(string s, string p)
//        {
//            if (s.Length == 0 && p.Length == 0)
//            {
//                return true;
//            }
//            else if (s.Length != 0 && p.Length == 0)
//            {
//                return false;
//            }
//            else if (p[0] == '*')
//            {
//                if (p.Length > 1 && p[1] == '*')
//                {
//                    return IsMatch2(s, p.Substring(1));
//                }
//                string copy = s;
//                string substring = p.Substring(1);
//                if (IsMatch2(s, substring))
//                {
//                    return true;
//                }

//                while (copy.Length > 0)
//                {
//                    copy = copy.Substring(1);
//                    if (IsMatch2(copy, substring))
//                    {
//                        return true;
//                    }
//                }
//            }
//            else if (s.Length == 0)
//            {
//                return false;
//            }
//            else if (s[0] == p[0] || p[0] == '?')
//            {
//                if (IsMatch2(s.Substring(1), p.Substring(1)))
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }

//            return false;
//        }
//    }
//}
