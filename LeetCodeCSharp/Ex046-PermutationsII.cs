/*
Given a collection of numbers that might contain duplicates, 
return all possible unique permutations. 

For example,
[1,1,2] have the following unique permutations:
[1,1,2], [1,2,1], and [2,1,1]. 

class Solution {
public:
    List<List<int> > permuteUnique(List<int> &num) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex046
    {
        public static List<List<int>> PermuteUnique(List<int> num)
        {
            throw new NotImplementedException();
        }

        private static void Perm(List<int> num, int k, List<List<int>> res)
        {
            throw new NotImplementedException();
        }

        private static bool NoSwap(int k, int i, List<int> num)
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