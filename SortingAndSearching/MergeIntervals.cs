using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAndSearching
{
    public static class MergeIntervals
    {
        public static IList<Interval> Merge(IList<Interval> intervals)
        {
            List<Interval> result = new List<Interval>();
            if (intervals==null || intervals.Count==0)
            {
                return result;
            }
            //Sort the intervals by starting time.
            intervals = SortIntervals(intervals);

            int firstIntervalStartTime = intervals[0].start;
            int firstIntervalEndTime = intervals[0].end;

            for (int i = 1; i < intervals.Count; i++)
            {
                Interval currentInterval = intervals[i];

                if (firstIntervalEndTime<currentInterval.start)
                {
                    result.Add(new Interval(firstIntervalStartTime, firstIntervalEndTime));

                    firstIntervalStartTime = currentInterval.start;
                    firstIntervalEndTime = currentInterval.end;
                }
                else
                {
                    firstIntervalEndTime = Math.Max(currentInterval.end, firstIntervalEndTime);
                }
            }
            result.Add(new Interval(firstIntervalStartTime, firstIntervalEndTime));
            return result;
        }

        private static IList<Interval> SortIntervals(IList<Interval> intervals)
        {
            return intervals.OrderBy(s => s.start).ToList();
        }
    }
}
