using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndSearching
{
    public static class MeargeKSortedLists
    {
        /* we can create sortedDictonary where dictonary is sorted by key and put all the values in there*/
        public static ListNode MergeKlists(ListNode[] lists)
        {
            SortedDictionary<int, Queue<ListNode>> sortedDic = new SortedDictionary<int, Queue<ListNode>>();

            for (int i = 0; i < lists.Length; i++)
            {
                while (lists[i] != null)
                {
                    if (!sortedDic.ContainsKey(lists[i].val))
                    {
                        sortedDic.Add(lists[i].val, new Queue<ListNode>());
                    }

                    sortedDic[lists[i].val].Enqueue(lists[i]);
                    lists[i] = lists[i].next;
                }
            }

            ListNode head = new ListNode(0);
            ListNode dummy = head;

            foreach (var i in sortedDic)
            {
                while (i.Value.Count > 0)
                {
                    dummy.next = i.Value.Dequeue();
                    dummy = dummy.next;
                }
            }

            return head.next;

        }
        /*Also we can go through all the list in array and compare two at a time*/

        public static ListNode MergeKLists2(ListNode[] lists)
        {
            
            int last = lists.Length - 1; ;
            while (last != 0)
            {
                int i = 0;
                int j = last;
                while (i < j)
                {
                    lists[i] = MergeLists(lists[i], lists[j]);
                    i++;
                    j--;

                    if (i >= j)
                    {
                        last = j;
                    }
                }
            }

            return lists[0];
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
