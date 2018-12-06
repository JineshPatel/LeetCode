using System;
using System.Collections.Generic;
using System.Text;

namespace BackTracking
{
    class FindSubsets
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();

            result.Add(new List<int>());

            for (int i = 0; i < nums.Length; i++)
            {
                int size = result.Count;

                for (int j = 0; j < size; j++)
                {
                    List<int> subset = new List<int>(result[j]);

                    subset.Add(nums[i]);
                    result.Add(subset);
                }
            }

            return result.ToArray();
        }
    }
}
