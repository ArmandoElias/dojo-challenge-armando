using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{

    /*
     * Challenge name: Insert Interval
        Description: 
        Given a set of non-overlapping and sorted intervals, insert a new interval into the intervals to create a final interval based 
        on the supplied intervals and the interval to be merged.

        Example 1:
        Input: Given [1,3],[6,9] Given to merge [2,5]
        Output:  [1,5],[6,9]

        Example 2:
        Input: Given [1,2],[3,5],[6,7],[8,10],[12,16] Given to merge [4,9]
             Output: [1,2],[3,10],[12,16]

        Example 3:
        Input: Given [1,3],[6,9],[12,16] Given to merge [2,5]
        Output: [1,5],[6,9],[12,16]

     */
    public static class InsertInterval
    {
        public static List<Interval> InsertNewInterval(List<Interval> intervals)
        {
            var newIntervals = new List<Interval>();
            var sorftIntervals = intervals
                                    .OrderBy(interval => interval.Start)
                                    .ToList();
          
            for (int i = 0; i < sorftIntervals.Count; i++)
            {
                var isLast = i + 1 == sorftIntervals.Count;
                var nextInterval = isLast ? i : i + 1;
                var currentInterval = sorftIntervals[i];

                while (currentInterval.Start <= sorftIntervals[nextInterval].End && sorftIntervals[nextInterval].Start <= currentInterval.End && !isLast)
                {
                    currentInterval.End = Math.Max(currentInterval.End, sorftIntervals[nextInterval].End);
                    sorftIntervals.Remove(sorftIntervals[nextInterval]);                    
                }

                if (!newIntervals.Contains(currentInterval))
                    newIntervals.Add(currentInterval); ;
            }
            return newIntervals;
        }
    }
}

public class Interval
{
    public int Start { get; set; }
    public int End { get; set; }

    public bool isNew { get; set; }
}
