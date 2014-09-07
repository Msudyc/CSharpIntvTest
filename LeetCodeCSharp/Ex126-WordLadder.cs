/*
Given two words (start and end), and a dictionary, find 
the length of shortest transformation sequence from start
to end, such that: 

1.Only one letter can be changed at a time
2.Each intermediate word must exist in the dictionary

For example, 

Given:
start = "hit"
end = "cog"
dict = ["hot","dot","dog","lot","log"]

As one shortest transformation is "hit" . "hot" . "dot" .
"dog" . "cog", return its length 5. 

Note:

.Return 0 if there is no such transformation sequence.
.All words have the same length.
.All words contain only lowercase alphabetic characters.

class Solution {
public:
    int ladderLength(string start, string end, unordered_set<string> &dict) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex126
    {
        public static int LadderLength(string start, string end, HashSet<string> dict)
        {
            throw new NotImplementedException();
        }
    }
}