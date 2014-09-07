/* Question 1.8
 
Assume you have a method isSubString which checks if ne word is a substring of another.
Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only
one call to isSubString (e.g., "waterbottle" is rotation of "erbottlewat").
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter01_Q08
    {
        public static bool IsRotation(string s1, string s2)
        {
            throw new NotImplementedException();
        }

        private static bool IsSubString(string s1, string s2)
        {
            return s1.Contains(s2);
        }
    }
}
