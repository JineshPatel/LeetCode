using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAll
{

    /*
     Write a program to find the node at which the intersection of two singly linked lists begins.


For example, the following two linked lists:

A:          a1 → a2
                   ↘
                     c1 → c2 → c3
                   ↗            
B:     b1 → b2 → b3
begin to intersect at node c1.


Notes:

If the two linked lists have no intersection at all, return null.
The linked lists must retain their original structure after the function returns.
You may assume there are no cycles anywhere in the entire linked structure.
Your code should preferably run in O(n) time and use only O(1) memory.*/
   public class MergePointTwoLinkedList
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int m = Helper.Length(headA);
            int n = Helper.Length(headB);

            if (m>n)
            {
              return  GetIntersectionNode(headB, headA);
            }
            
            int d = n - m;

            for (int i = 0; i < d; i++)
            {
                headB = headB.next;
            }

            while (headB!=null && headA !=null )
            {
                if (headA==headB)
                {
                    return headA;
                }
                headA = headA.next;
                headB = headB.next;
            }
            return null;
        }
    }
}
