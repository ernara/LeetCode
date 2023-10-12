using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class Task39
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList <IList<int>> result = new List<IList<int>>();
            CombinationSum(candidates,target, new List<int>(),  0, result, new HashSet<string>());
            return result;
        }

        public void CombinationSum(int[] candidates, int target, List<int> current , int sum, IList<IList<int>> result, HashSet<string> h)
        {
            if (sum>target)
            {
                return;
            }
            else if(sum==target)
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
                for (int i = 0; i < candidates.Length; i++)
                {
                    current.Add(candidates[i]);
                    CombinationSum(candidates, target, new List<int>(current), sum + candidates[i], result, h);
                    current.RemoveAt(current.Count-1);
                }
            }
        }
    }
}
