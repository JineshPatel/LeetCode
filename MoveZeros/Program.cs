using System;

namespace MoveZeros
{
   /*Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Example:

Input: [0,1,0,3,12]
Output: [1,3,12,0,0]
Note:

You must do this in-place without making a copy of the array.
Minimize the total number of operations.*/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            

            MoveZeros1(new int[] { 0, 1, 0, 2, 3 });
        }
        

        static void MoveZeros1(int[] nums)
        {
            int zeroCount = 0;
            for (int oI = 0; oI < nums.Length; oI++)
            {
                if (nums[oI] == 0)
                {
                    zeroCount += 1;
                }
                else
                {
                    nums[oI - zeroCount] = nums[oI];
                }

            }

            if (zeroCount > 0)
            {
                int zeroStartIndex = nums.Length - zeroCount;

                for (int zI = 0; zI < zeroCount; zI++)
                {
                    nums[zeroStartIndex + zI] = 0;
                }
            }


        }
    }
}
