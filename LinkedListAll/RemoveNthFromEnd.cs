using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAll
{
   public  class RemoveNthFromEnd
    {
        int index = 0;
        public ListNode RemoveNthFromEnds(ListNode head, int n)
        {

            if (head == null)
            { return null; }
            RemoveNthFromEnds(head.next, n);
           
            index++;

            if (index - 1 == n)
            {
                head.next = head.next.next;

            }
            return head;
        }
    }
}
