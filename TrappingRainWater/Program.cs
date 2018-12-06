using System;

namespace TrappingRainWater
{
    /*Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.


The above elevation map is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped. Thanks Marcos for contributing this image!

Example:

Input: [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
        }

        public static int Trap(int[] height)
        {
            int totalWater = 0;
            //Find Max Height on right side

            int maxSeenSofar = 0;
            int[] maxSeenRight = new int[height.Length];
            for (int i = height.Length-1; i >= 0; i--)
            {
                if (height[i]>maxSeenSofar)
                {
                    maxSeenSofar = height[i];
                    maxSeenRight[i] = maxSeenSofar;
                }
                else
                {
                    maxSeenRight[i] = maxSeenSofar;
                }
            }
            //find MaxHightOfLeftTower
            int maxSeenLeft = 0; // we will keep track of while traversing thought array.

            for (int i = 0; i < height.Length; i++)
            {
                totalWater = totalWater + Math.Max(Math.Min(maxSeenLeft,maxSeenRight[i])-height[i],0);
                if (height[i]> maxSeenLeft)
                {
                    maxSeenLeft = height[i];
                }
            }
            return totalWater;
        }
    }
}
