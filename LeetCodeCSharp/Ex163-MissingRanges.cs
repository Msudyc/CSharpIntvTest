/*
Given a sorted integer array where the range of elements 
are [lower, upper] inclusive, return its missing ranges.

For example, given [0, 1, 3, 50, 75], lower = 0 and 
upper = 99, return ["2", "4->49", "51->74", "76->99"].

class Solution {
public:
    vector<string> findMissingRanges(int A[], int n, int lower, int upper) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex163
    {
        public static List<String> FindMissingRanges(int[] A, int lower, int upper)
        {
            throw new NotImplementedException();
        }

        private static String GetRange(int from, int to)
        {
            return (from == to) ? from.ToString() : from + "->" + to;
        }
    }
}