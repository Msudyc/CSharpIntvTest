﻿/* Question 17.11
 
Implement a method rand7() given rand5(). That is, given a method that generates a 
random number between 0 and 4 (inclusive), write a method that generates a random 
number between 0 and 6 (inclusive). 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q11
    {
        public static int Rand7()
        {
            throw new NotImplementedException();
        }

        private static int Rand5()
        {
            Random r = new Random();
            return r.Next(5);
        }
    }
}
