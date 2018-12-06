using System;


/*
 You are given two arrays (without duplicates) nums1 and nums2 where nums1’s elements are subset of nums2. Find all the next greater numbers for nums1's elements in the corresponding places of nums2.

The Next Greater Number of a number x in nums1 is the first greater number to its right in nums2. If it does not exist, output -1 for this number.

Example 1:
Input: nums1 = [4,1,2], nums2 = [1,3,4,2].
Output: [-1,3,-1]
Explanation:
    For number 4 in the first array, you cannot find the next greater number for it in the second array, so output -1.
    For number 1 in the first array, the next greater number for it in the second array is 3.
    For number 2 in the first array, there is no next greater number for it in the second array, so output -1.
Example 2:
Input: nums1 = [2,4], nums2 = [1,2,3,4].
Output: [3,-1]
Explanation:
    For number 2 in the first array, the next greater number for it in the second array is 3.
    For number 4 in the first array, there is no next greater number for it in the second array, so output -1.
Note:
All elements in nums1 and nums2 are unique.
The length of both nums1 and nums2 would not exceed 1000.
 */
namespace NextGraterElement
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] findnums = new int[] { 2,4};
            int[] nums = new int[] { 1,2,3,4};

            var res = NextGreaterElement1(findnums, nums);

            Console.ReadKey();       }

        public static int[] NextGreaterElement1(int[] findNums, int[] nums)
        {
            int[] result = new int[findNums.Length];

            for (int i = 0; i < findNums.Length; i++)
            {
                bool found = false;
                int j = 0;
                for ( j = 0; j < nums.Length; j++)
                {
                   

                    if (found && findNums[i]<nums[j])
                    {
                        result[i] = nums[j];
                        break;
                    }
                    if (findNums[i]==nums[j])
                    {
                        found = true;
                    }
                   
                }
                if (j == nums.Length)
                {
                    result[i] = -1;
                }
            }
            return result;
        }
    }
}
