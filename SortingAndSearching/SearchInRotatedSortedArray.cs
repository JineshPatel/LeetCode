using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndSearching
{
    /*
     * Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.

        (i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).

        You are given a target value to search. If found in the array return its index, otherwise return -1.

        You may assume no duplicate exists in the array.

        Your algorithm's runtime complexity must be in the order of O(log n).

        Example 1:

        Input: nums = [4,5,6,7,0,1,2], target = 0
        Output: 4
        Example 2:

        Input: nums = [4,5,6,7,0,1,2], target = 3
        Output: -1
     */
    public static class SearchInRotatedSortedArray
    {
        public static int Search(int[] nums, int target)
        {

            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] == target)
                    return mid;

                if (nums[low] <= nums[mid])// left halfsorted
                {
                    if (target >= nums[low] && target < nums[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }

                else if (nums[mid] <= nums[high]) //Right half sorted
                {
                    if (target > nums[mid] && target <= nums[high])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
