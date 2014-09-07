/* Question 18.3
 
Write a method to randomly generate a set of m integers from an array of size n. 
Each element must have equal probability of being chosen. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q03
    {
        public static int[] PickMRandomly(int[] original, int m)
        {
            throw new NotImplementedException();
        }

        private static int Rand(int lower, int higher)
        {
            return lower + new Random().Next(higher - lower + 1);
        }
    }
}
