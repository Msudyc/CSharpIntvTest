/*
Given a collection of intervals, merge all overlapping intervals.

For example,
 Given [1,3],[2,6],[8,10],[15,18],
 return [1,6],[8,10],[15,18]. 

 Definition for an interval.
  struct Interval {
      int start;
      int end;
      Interval() : start(0), end(0) {}
      Interval(int s, int e) : start(s), end(e) {}
  };

class Solution {
public:
    List<Interval> merge(List<Interval> &intervals) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex055
    {
        public static List<Interval> Merge(List<Interval> intervals)
        {
            throw new NotImplementedException();
        }

        private static int IsLower(Interval v1, Interval v2)
        {
            return v1.Start - v2.Start;
        }
    }
}