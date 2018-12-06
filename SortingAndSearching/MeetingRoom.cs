using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndSearching
{
    /*
     * Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei), find the minimum number of conference rooms required.

        Example 1:

        Input: [[0, 30],[5, 10],[15, 20]]
        Output: 2
        Example 2:

        Input: [[7,10],[2,4]]
        Output: 1
     */
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }


    public static class MeetingRoom
    {
        public static int MinMeetingRooms(Interval[] intervals)
        {
            if (intervals==null)
            {
                return 0;
            }
            if (intervals.Length<=1) 
            {
                return intervals.Length;
            }

            int[] startTimes = new int[intervals.Length];
            int[] endTimes = new int[intervals.Length];

            for (int i = 0; i < intervals.Length; i++)
            {
                Interval curr = intervals[i];

                startTimes[i] = curr.start;
                endTimes[i] = curr.end;
            }

            Array.Sort(startTimes);
            Array.Sort(endTimes);

            int minMeetingRooms = 0;
            int endTimesIterator = 0;
            for (int i = 0; i < startTimes.Length; i++)
            {
                minMeetingRooms++;       //Increment the room for the current meeting that is starting.
                                         //Check if startTime of current meeting is after endTime of meeting that is suppose to end first.
                if (startTimes[i] >= endTimes[endTimesIterator])
                {
                    minMeetingRooms--;   //since one meeting ended, a room got empty.
                    endTimesIterator++;  //move to the next endTime.
                }
            }
            return minMeetingRooms;
        }

    }
}
