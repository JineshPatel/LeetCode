using System;

namespace MediadnOfTwoSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[] { 1,3};
            int[] n2 = new int[] { 2 };

            var s = FindMedianSortedArrays(n1, n2);
            Console.ReadKey();
        }

        public static double FindMedianSortedArrays1(int[] nums1, int[] nums2)
        {
            double m=0.0;
            int n = 0,s=0;
            int[] joinedArray = new int[nums1.Length + nums2.Length];
            //join both array as sorted array then if odd total count return middle element else return middle + middle+1 /2
            if (nums1.Length>nums2.Length)
            {
                n = nums1.Length;
                s = nums2.Length;
            }
            else
            {
                n = nums2.Length;
                s = nums1.Length;
            }
           
            int i=0, j = 0,k=0;
            while (i<s &&j<s)
            {
                if (nums1[i]<nums2[j])
                {
                    joinedArray[k] = nums1[i];
                    k++;i++;
                }
                else
                {
                    joinedArray[k] = nums2[j];
                    k++; j++;
                }
            }
            if (i<nums1.Length)
            {
                while (i<nums1.Length)
                {
                    joinedArray[k] = nums1[i];
                    k++;i++;
                }
            }
            if (j<nums2.Length)
            {
                while (j<nums2.Length)
                {
                    joinedArray[k] = nums2[j];
                    k++; j++;
                }
            }
            if (joinedArray.Length%2==0)
            {
                m = Convert.ToDouble((joinedArray[joinedArray.Length / 2]) + joinedArray[(joinedArray.Length / 2) - 1]) / 2.0;
            }
            else
            {
                m = joinedArray[joinedArray.Length / 2];
            }
            return m;
        }


        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            //find smallest array and switch them.
            if (nums1.Length>nums2.Length)
            {
                return FindMedianSortedArrays(nums2, nums1);
            }

            int x = nums1.Length;
            int y = nums2.Length;

            int low = 0, high = x;
            //loop thourgh smallest of two array.
            while (low<=high)
            {
                int partitionX = (low + high) / 2;
                int partitionY = (x + y + 1) / 2 - partitionX;

                int maxLeftX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
                int minRightX = (partitionX == x) ? int.MaxValue : nums1[partitionX];

                int maxLeftY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
                int minRightY = (partitionY == y) ? int.MaxValue : nums2[partitionY];

                if (maxLeftX<= minRightY && maxLeftY<=minRightX)
                {
                    if ((x+y)%2==0)
                    {
                        return ((double)Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2;
                    }
                    else
                    {
                        return (double)Math.Max(maxLeftX, maxLeftY);
                    }
                }
                else if (maxLeftX>minRightY)
                {
                    high = partitionX - 1;
                }
                else
                {
                    low = partitionX + 1;
                }
            }

            return 0.0;
        }
    }
}
