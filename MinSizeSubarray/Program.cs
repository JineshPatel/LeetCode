using System;

namespace MinSizeSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 9;
            int[] nums = new int[] { 2, 3, 1, 2, 4, 3 };
            Console.WriteLine(MinSubArrayLen(s,nums));

        }

        public static int MinSubArrayLen(int s, int[] nums)
        {

            var minLength = int.MaxValue;
            var total = 0;
            for (int start = 0, end = 0; end < nums.Length; end++)
            {
                total += nums[end];
                while (total >= s && start <= end)
                {
                    minLength = Math.Min(minLength, end - start + 1);
                    total -= nums[start++];
                }
            }
            return minLength == int.MaxValue ? 0 : minLength;
           }
    }
}
