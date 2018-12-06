using System;
using System.Collections.Generic;

namespace SortingAndSearching
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine( FirstBadVersion.FirstBadVersion1(9));

            //Interval m1 = new Interval(0, 30);
            //Interval m2 = new Interval(5, 10);
            //Interval m3 = new Interval(15, 20);
            //Interval m4 = new Interval(7, 10);
            //Interval m5 = new Interval(2,4);
            //Interval[] intervals = new Interval[] { m1, m2, m3 };
            //Interval[] intervals1 = new Interval[] { m4, m5 };
            //var re = MeetingRoom.MinMeetingRooms(intervals1);


          //  int[] n1 = new int[] { 1, 2, 3, 0, 0, 0 };
            //int[] n2 = new int[] { 2, 5, 6 };
            //MeargeSortedArrays.Merge(n1, 3, n2, 3);


            ListNode l1 = new ListNode(1);
            ListNode l11 = new ListNode(4);
            ListNode l12 = new ListNode(5);

            l1.next = l11;
            l11.next = l12;

            ListNode l2 = new ListNode(1);
            ListNode l21 = new ListNode(3);
            ListNode l22 = new ListNode(4);

            l2.next = l21;
            l21.next = l22;

            ListNode l3 = new ListNode(2);
            ListNode l31 = new ListNode(6);

            l3.next = l31;

            ListNode[] listNodes = new ListNode[] { l1, l2, l3 };
            ListNode result =  MeargeKSortedLists.MergeKLists2(listNodes);


            while (result!=null)
            {
                Console.Write(result.val + "->");
                result = result.next;
            }
            Console.Write("NULL");


            int[] n1 = new int[] { 4, 5, 6, 7, 0, 1, 2 };

            //  SearchInRotatedSortedArray.Search(n1, 3);


            Interval m1 = new Interval(1, 3);
            Interval m2 = new Interval(2, 6);
            Interval m3 = new Interval(8, 10);
            Interval m4 = new Interval(15, 18);
            // Interval m5 = new Interval(2, 4);

            List<Interval> intervals = new List<Interval>() { m1, m2, m3, m4 };

            MergeIntervals.Merge(intervals);

            List<List<int>> nums = new List<List<int>>() {
                new List<int> { 4, 10, 15, 24, 26 } ,
                new List<int> { 0, 9, 12, 20 } ,
                new List<int> { 5, 18, 22, 30 } 
            };

          var t =  SmallestRange.SmallestRange1(nums.ToArray());

            Console.ReadKey();
        }
    }
}
