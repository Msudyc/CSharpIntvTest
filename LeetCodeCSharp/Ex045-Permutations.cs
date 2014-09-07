/*
Given a collection of numbers, return all possible permutations. 

For example,
[1,2,3] have the following permutations:
[1,2,3], [1,3,2], [2,1,3], [2,3,1], [3,1,2], and [3,2,1]. 

class Solution {
public:
    List<List<int> > permute(List<int> &num) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex045
    {
        public static List<List<int>> Permute(List<int> num)
        {
            throw new NotImplementedException();
        }

        private static void Perm(List<int> num, int k, List<List<int>> res)
        {
            throw new NotImplementedException();
        }

        private static void Swap(List<int> num, int i, int j)
        {
            int tmp = num[i];
            num[i] = num[j];
            num[j] = tmp;
        }
    }
}