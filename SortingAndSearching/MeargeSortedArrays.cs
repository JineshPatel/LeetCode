using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAndSearching
{
   public static class MeargeSortedArrays
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int j = 0;
            int l = nums1.Length - n;

            for (int i = 0; i < nums1.Length - 1 && j < nums2.Length; i++)
            {
                if (nums1[i] > nums2[j])
                {
                    //shift
                    nums1 = ShiftArray(nums1, i, l);
                    nums1[i] = nums2[j];
                    j++;
                    l++;
                }

            }

            if (j < nums2.Length)
            {
                while (j != nums2.Length)
                {
                    nums1[l] = nums2[j];
                    j++;
                    l++;
                }
            }


        }

        public static int[] ShiftArray(int[] nums1, int i, int l)
        {
            for (int k = l - 1; k >= i; k--)
            {
                nums1[k + 1] = nums1[k];
            }
            return nums1;
        }

        public static void Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            if (n <= 0) return;

            int total = m + n - 1;

            int i = m - 1;
            int j = n - 1;

            while (total >= 0 && j >= 0)
            {
                if (i >= 0 && (nums1[i] > nums2[j])) nums1[total--] = nums1[i--];
                else
                {
                    nums1[total--] = nums2[j--];
                }
            }
            return;
        }
    }
}
