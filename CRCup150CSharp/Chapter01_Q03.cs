/* Question 1.3
 
 Given two strings, write a method to decide if one is a permutation of the other.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Text;
    using System.Collections.Generic;
    #endregion

    public class Chapter01_Q03
    {
        public static bool Permutation(string s, string t)
        {
            throw new NotImplementedException();
        }

        public static bool Permutation2(string s, string t)
        {
            throw new NotImplementedException();
        }

        private static string Sort(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
    }
}
