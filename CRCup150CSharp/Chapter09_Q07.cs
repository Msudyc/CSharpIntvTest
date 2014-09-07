/* Question 9.7
 
Implement the "paint fill" function that one might see on many image editing 
programs. That is, given a screen (represented by a two-dimensional array of 
colors), a point and a new color, fill in the surrounding area until the color
changes from the original color. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q07
    {
        public enum Color
        {
            Black, White, Red, Yellow, Green
        }

        public static void PaintFill(
            Color[,] screen,
            int x,
            int y,
            Color nColor)
        {
            throw new NotImplementedException();
        }
    }
}
