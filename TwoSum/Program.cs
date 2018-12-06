using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = new int[] { 2, 7, 11, 15 };
            var res = TwoSum(nums, 18);
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            //int[] result = new int[2];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (i!=j)
            //        {
            //            if (target== nums[i]+nums[j])
            //            {
            //                result[0] = i;
            //                result[1] = j;
            //                return result;
            //            }
            //        }
            //    }
            //}

            //return result;

            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map.Add(nums[i], i);
            }
            return new int[] { };
        }
    }
}
