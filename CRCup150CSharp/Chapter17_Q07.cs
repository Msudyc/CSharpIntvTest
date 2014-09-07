/* Question 17.7
 
Given any integer, print an English phrase that describes the integer 
(e.g., "one thousand two hundred thirty four") 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q07
    {
        private static string[] digits = 
            {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        private static string[] teens =
            {"eleven", "twelve", "thirteen", "fourteen", "fifteen", 
             "sixteen", "seventeen", "eighteen", "nineteen"};
        private static string[] tens = 
            { "ten", "twenty", "thirty", "forty", "fifty", 
              "sixty", "seventy", "eighty", "ninety" };
        private static string[] bigs = { "", "thousand", "million" };

        public static string NumToString(int num)
        {
            throw new NotImplementedException();
        }

        private static string NumToString100(int num)
        {
            throw new NotImplementedException();
        }
    }
}
