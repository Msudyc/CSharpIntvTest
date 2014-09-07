/*
Given two words (start and end), and a dictionary, find 
all shortest transformation sequence(s) from start to end,
such that: 

1.Only one letter can be changed at a time
2.Each intermediate word must exist in the dictionary

For example, 

Given:
start = "hit"
end = "cog"
dict = ["hot","dot","dog","lot","log"]

Return
  [
    ["hit","hot","dot","dog","cog"],
    ["hit","hot","lot","log","cog"]
  ]

Note:

.All words have the same length.
.All words contain only lowercase alphabetic characters.

class Solution {
public:
    List<List<string>> findLadders(string start, string end, unordered_set<string> &dict) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex127
    {
        public static List<List<string>> FindLadders(string start, string end, HashSet<string> dict)
        {
            throw new NotImplementedException();
        }

        private static void DFS(
            string start, 
            string end, 
            Dictionary<string, List<string>> graph, 
            List<string> oneSoln, 
            List<List<string>> soln)
        {
            throw new NotImplementedException();
        }
    }
}