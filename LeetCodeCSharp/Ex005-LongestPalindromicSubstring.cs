/*
Given a string S, find the longest palindromic substring in S. 
You may assume that the maximum length of S is 1000, and there 
exists one unique longest palindromic substring.

class Solution {
public:
    string longestPalindrome(string s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex005
    {
        public static string LongestPalindrome(string s)
        {
            throw new NotImplementedException();
        }
        
        private static bool IsPalindrome(string s, int i, int j)
        {
            throw new NotImplementedException();
        }

        public static string LongestPalindrome1(string s)
        {
            /* DP
            Define P[ i, j ] ← true if the substring Si ... Sj is a palindrome, otherwise false.
            P[ i, j ] ← ( P[ i+1, j-1 ] and Si = Sj )
            The base cases are:
                P[ i, i ] ← true
                P[ i, i+1 ] ← ( Si = Si+1 )
            */
            throw new NotImplementedException();
        }

        public static string LongestPalindrome2(string s)
        {
            // Expand from center
            throw new NotImplementedException();
        }

        private static string expandAroundCenter(string s, int c1, int c2) 
        {
            throw new NotImplementedException();
        }
    }
}