/* Question 18.6
 
Describe an algorithm to find the smallest one million numbers in one billion numbers. 
Assume that the computer memory can hold all one billion numbers. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q06
    {
        public static int FindRank(int[] array, int rank)
        {
            throw new NotImplementedException();
        }

        private static int Rank(int[] array, int left, int right, int rank)
        {
            throw new NotImplementedException();
        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {
            throw new NotImplementedException();
        }

        private static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        private static int FindMax(int[] arr, int left, int right)
        {
            int max = int.MinValue;
            for (int i = left; i <= right; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
    }
}
