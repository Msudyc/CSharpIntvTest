﻿/* Question 5.1
 
You are given two 32-bit number, N and M, and two bit positions, i and j.
Write a method to insert M into N such that M starts at bit j and ends at 
bit i. You can assume that the bits j though i have enough space to fit all 
of M. That is, if M=10011, you can assume that there are at least 5 bits
between j and i. You would not, for example, have j=3 and i=2, because M 
could not fully fit between bit 3 and bit 2.
Example
Input: N=10000000000, M=10011, i=2, j=6
Output: N=10001001100
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter05_Q01
    {
        public static int UpdateBits(int n, int m, int i, int j)
        {
            throw new NotImplementedException();
        }
    }
}
