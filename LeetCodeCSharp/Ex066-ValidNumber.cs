/*
Validate if a given string is numeric.

Some examples:
"0" => true
" 0.1 " => true
"abc" => false
"1 a" => false
"2e10" => true

Note: It is intended for the problem statement to be 
ambiguous. You should gather all requirements up front 
before implementing one. 

class Solution {
public:
    bool isNumber(const char *s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex066
    {
        public static bool IsNumber(string s)
        {
            int[,] mat = {{0 ,0 ,0 ,0 ,0 ,0 ,0}, // false
                          {0 ,2 ,3 ,0 ,1 ,4 ,0}, // 1
                          {0 ,2 ,5 ,6 ,9 ,0 ,10},// 2
                          {0 ,5 ,0 ,0 ,0 ,0 ,0}, // 3
                          {0 ,2 ,3 ,0 ,0 ,0 ,0}, // 4
                          {0 ,5 ,0 ,6 ,9 ,0 ,10},// 5
                          {0 ,7 ,0 ,0 ,0 ,8 ,0}, // 6
                          {0 ,7 ,0 ,0 ,9 ,0 ,10},// 7
                          {0 ,7 ,0 ,0 ,0 ,0 ,0}, // 8
                          {0 ,0 ,0 ,0 ,9 ,0 ,10},// 9
                          {10,10,10,10,10,10,10} // 10
                         };
            throw new NotImplementedException();
        }
    }
}