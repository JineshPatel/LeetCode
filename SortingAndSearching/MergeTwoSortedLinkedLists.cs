using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndSearching
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public static class MergeTwoSortedLinkedLists
    {
        public static ListNode MergeTwoLists(ListNode l1,ListNode l2)
        {
            if (l1==null)
            {
                return l2;
            }
            if (l2==null)
            {
                return l1;
            }


            ListNode s = new ListNode(0);
            ListNode newNode = new ListNode(0);


            if (l1.val<=l2.val)
            {
                s = l1;
                l1 = s.next;
            }
            else
            {
                s = l2;
                l2 = s.next;
            }
            newNode = s;


            while (l1 != null && l2!=null)
            {
                if (l1.val<= l2.val)
                {
                    s.next = l1;
                    s = l1;
                    l1 = s.next;
                }
                else
                {
                    s.next = l2;
                    s = l2;
                    l2 = s.next;
                }
            }

            if (l1 != null)
            {
                s.next = l1;
            }
            if (l2!=null)
            {
                s.next = l2;
            }
            return newNode;
        }
        public static ListNode MergeLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            if (l1.val < l2.val)
            {
                l1.next = MergeLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeLists(l2.next, l1);
                return l2;
            }
        }

    }

  
}
