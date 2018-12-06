using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAll
{
   public static class Helper
    {

        public static int Length(ListNode list)
        {
            int len = 0;

            while(list.next!= null)
            {
                len++;
                list = list.next;
            }

            return len;
        }

    }
}
