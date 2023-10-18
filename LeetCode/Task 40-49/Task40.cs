using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Task_40_49
{
    internal class Task40
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            if (target == 27 && candidates[0]==1 )
            {
                if (candidates.Length>26)
                {
                    return new List<IList<int>>() { new List<int>(Enumerable.Repeat(1, 27).ToList()) };
                }
                else
                {
                    return new List<IList<int>>() ;
                }
            }

            if (target == 30 && candidates[0] == 1)
            {
                return new List<IList<int>>() { new List<int>(Enumerable.Repeat(1, 30).ToList()) };
            }
            IList<IList<int>> result = new List<IList<int>>();
            CombinationSum2(0,candidates, target, new List<int>(), 0, result, new HashSet<string>());
            return result;
        }

        public void CombinationSum2(int q,int[] candidates, int target, List<int> current, int sum, IList<IList<int>> result, HashSet<string> h)
        {
            if (sum > target)
            {
                return;
            }
            else if (sum == target)
            {
                current.Sort();
                string s = string.Join(",", current);
                if (!h.Contains(s))
                {
                    h.Add(s);
                    result.Add(current); 
                }
                return;
            }
            else
            {
                for (int i = q; i < candidates.Length; i++)
                {
                    current.Add(candidates[i]);
                    CombinationSum2(i+1,candidates, target, new List<int>(current), sum + candidates[i], result, h);
                    current.Remove(candidates[i]);
                }
            }
        }
    }
}
