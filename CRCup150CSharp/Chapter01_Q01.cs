/* Question 1.1
 
Inplement an algorithm to determine if a string has all unique characters. 
What if you cannot use additional data structures? 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter01_Q01
    {
        public static bool IsUniqueCharacters(string str)
        {
            throw new NotImplementedException();
        }

        public static bool IsUniqueCharacters2(string str)
        {
            throw new NotImplementedException();
        }

        private static int GetBit(int[] map, char s)
        {
            return map[s/32] >> (s%32) & 0x1;
        }

        private static void SetBit(int[] map, char s)
        {
            map[s/32] |=  0x1 << (s%32);
        }
    }
}
