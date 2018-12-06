using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAll
{
    /*Given a linked list, determine if it has a cycle in it.

Follow up:
Can you solve it without using extra space?*/
    public class Cycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head.next==null)
            {
                return false;
            }
            ListNode slow=head;
            ListNode fast=head;

            while (slow!=null && fast!=null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast==slow)
                {
                    return true;
                }
               
            }

            return false;
        }
    }
}
