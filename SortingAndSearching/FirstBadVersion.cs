using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndSearching
{
  public static  class FirstBadVersion
    {
        public static int FirstBadVersion1(int n)
        {
            int low = 0;
            int high = n;

            while(low+1<high)
            {
                int mid = low +( high-low) / 2;

                if (isBadVersion(mid))
                {
                    high = mid;
                }
                else
                {
                    low = mid;
                }
            }

            if (isBadVersion(low))
            {
                return low;
            }
            return high;
        }

        
        private  static bool isBadVersion(int mid)
        {
          return  true;
        }
    }
}
