using System;
using System.Collections.Generic;
using System.Text;

namespace BackTracking
{
    class Permutations2
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> sols = new List<IList<int>>();
            Backtrace(sols, nums, 0);
            return sols;
        }

        private void Backtrace(IList<IList<int>> sols, int[] nums, int start)
        {
            if (start>= nums.Length)
            {
                sols.Add(new List<int>(nums));
            }

            HashSet<int> used = new HashSet<int>();

            for (int i = start; i < nums.Length; i++)
            {
                if (used.Contains(nums[i]))
                {
                    continue;
                }
                Swap(nums, start, i);
                Backtrace(sols, nums, start + 1);
                Swap(nums, start, i);
                used.Add(nums[i]);
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }
    }
}
