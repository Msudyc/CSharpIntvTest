/* Question 18.9
 
Numbers are randomly generated and passed to a method. Write a program to find and 
maintain the median value as new values are generated. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q09
    {
        private SortedSet<int> maxHeap = new SortedSet<int>();
        private SortedSet<int> minHeap = new SortedSet<int>();

        public void AddNewNumber(int num)
        {
            throw new NotImplementedException();
        }

        public double GetMedian()
        {
            throw new NotImplementedException();
        }
    }
}
