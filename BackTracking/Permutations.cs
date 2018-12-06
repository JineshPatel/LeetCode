using System;
using System.Collections.Generic;
using System.Text;

namespace BackTracking
{
  public static  class Permutations
    {
        public static List<string> PermutationOfString(string s)
        {
            List<string> result = new List<string>();
            permute("", s, result);
            return result;
        }

        private static void permute(string prefix,string suffix,List<string> results)
        {
            if (suffix.Length==0)
            {
                results.Add(prefix);
                return;
            }

            for (int i = 0; i < suffix.Length; i++)
            {
                string rem = suffix.Substring(0, i) + suffix.Substring(i + 1);
                permute(prefix + suffix[i],rem, results);
            }
        }
        static List<List<int>> result = new List<List<int>>();
        public static IList<IList<int>> PermutationOfInt(int[] nums)
        {
           
           
           // premutationInt(nums, 0, result);
           // return result.ToArray();

            var retval = new List<IList<int>>();
            if (nums == null || nums.Length == 0) return retval;
            PermuteNum(retval, nums, new List<int>());
            return retval;
        }

     

        private static void premutationInt(int[] nums,int start,List<List<int>> result)
        {
            if (start>=nums.Length)
            {
                List<int> permu = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    permu.Add(nums[i]);
                }
                result.Add(permu);
                return;
            }

            for (int i = start; i < nums.Length; i++)
            {
                swap(nums, start, i);
                premutationInt(nums, start + 1, result);
                swap(nums, start, i);
            }
        }

        private static void swap(int[] nums,int i,int j)
        {
            int temp = nums[j];
            nums[j] = nums[i];    
            nums[i] = temp;
        }


        static void PermuteNum(List<IList<int>> retval, int[] nums, List<int> curList)
        {
            if (curList.Count == nums.Length)
            {
                retval.Add(curList);
                return;
            }

            for (int m = 0; m < nums.Length; m++)
            {
                if (curList.Contains(nums[m])) continue;
                var newList = new List<int>(curList);
                newList.Add(nums[m]);
                PermuteNum(retval, nums, newList);

            }
        }
    }
}
