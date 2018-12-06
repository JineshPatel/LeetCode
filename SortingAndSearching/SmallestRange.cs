using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAndSearching
{
    /*
     * You have k lists of sorted integers in ascending order. Find the smallest range that includes at least one number from each of the k lists.

        We define the range [a,b] is smaller than range [c,d] if b-a < d-c or a < c if b-a == d-c.

        Example 1:
        Input:[[4,10,15,24,26], [0,9,12,20], [5,18,22,30]]
        Output: [20,24]
        Explanation: 
        List 1: [4, 10, 15, 24,26], 24 is in range [20,24].
        List 2: [0, 9, 12, 20], 20 is in range [20,24].
        List 3: [5, 18, 22, 30], 22 is in range [20,24].
        Note:
        The given list may contain duplicates, so ascending order means >= here.
        1 <= k <= 3500
        -105 <= value of elements <= 105.
        For Java users, please note that the input type has been changed to List<List<Integer>>. And after you reset the code template, you'll see this point.
     */
   public static class SmallestRange
    {
        public static int[] SmallestRange1(IList<IList<int>> nums)
        {
            //int min = int.MinValue;
            //int max = int.MaxValue;
            //int range = int.MaxValue;

            //for (int i = 0; i < nums.Count; i++)
            //{

            //}

            var list = new List<Tuple<int, int>>();

            // merge lists
            for (int k = 0; k < nums.Count; k++)
            {
                for (int i = 0; i < nums[k].Count; i++)
                {
                    list.Add(new Tuple<int, int>(nums[k][i], k));
                }
            }

            list = list.OrderBy(i => i.Item1).ToList();

            var (min, max) = (list[0].Item1, list[list.Count - 1].Item1);
            int range = max - min;
            var f = new int[nums.Count];

            var c = 0;
            int left = 0;
            int right = 0;


            // sliding window
            while (right < list.Count)
            {
                if (f[list[right].Item2]++ == 0) c++;

                //contract
                while (c == nums.Count && left < right)
                {
                    if (list[right].Item1 - list[left].Item1 < range)
                    {
                        (min, max) = (list[left].Item1, list[right].Item1);
                        range = max - min;
                    }

                    if (--f[list[left].Item2] == 0) c--;
                    left++;
                }
                right++;
            }

            return new int[2] { min, max };
        }
    }
}
