using System;
using System.Collections.Generic;

namespace MaxsizeSubarraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] n = new int[] { 1, -1, 5, -2, 3 };
             var s = MaxSubArrayLen(n, 2);
        }

        public static int MaxSubArrayLen(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int sum=0, max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (sum == k)
                {
                    max = Math.Max(max, i + 1);
                }

                int diff = sum - k;

                if (dic.ContainsKey(diff))
                {
                    max = Math.Max(max, i - dic[diff]);
                }

                if (!dic.ContainsKey(sum))
                {
                    dic.Add(sum, i);
                }
            }

            return max;
        }
    }
}
