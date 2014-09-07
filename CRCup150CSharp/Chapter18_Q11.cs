/* Question 18.11
 
Imagine you have square matrix, where each cell (pixel) is either black or white. 
Design an algorithm to find the maximum subsquare such that all four borders are
filled with black pixels. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q11
    {
        public static SubSquare FindSquare(int[,] matrix)
        {
            throw new NotImplementedException();
        }

        private static SubSquare FindSquareWithSize(SquareCell[,] matrix, int size)
        {
            throw new NotImplementedException();
        }

        private static bool IsSquare(SquareCell[,] matrix, int row, int col, int size)
        {
            throw new NotImplementedException();
        }

        private static SquareCell[,] Process(int[,] matrix)
        {
            throw new NotImplementedException();
        }

        public class SubSquare
        {
            public int Row { get; set; }
            public int Col { get; set; }
            public int Size { get; set; }
        }

        private class SquareCell
        {
            internal int ZerosRight { get; set; }
            internal int ZerosBelow { get; set; }
        }
    }
}
