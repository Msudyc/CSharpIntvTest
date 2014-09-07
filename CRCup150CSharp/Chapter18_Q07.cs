/* Question 18.7
 
Given a list of words, write a program to find the longest word made of other words in the list.
Example:
Input: cat, banana, dog, nana, walk, walker, dogwalker
Output: dogwalker
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q07
    {
        public static string PrintLongestWord(string[] arr)
        {
            throw new NotImplementedException();
        }

        private static bool CanBuildWord(string str, bool original, Dictionary<string, bool> map)
        {
            throw new NotImplementedException();
        }

        public class LenComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return y.Length - x.Length;
            }
        }
    }
}
