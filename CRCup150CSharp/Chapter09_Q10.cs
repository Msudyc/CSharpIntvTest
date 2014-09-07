/* Question 9.10
 
You have a stack of n boxes, with widths wi, heights hi, and depths di. 
The boxes cannot be rotated and can only be stacked on top of one another
if each box in the stack is strictly larger than the box above it in with,
height, and depth. Implement a method to build the tallest stack possible,
where the height of a stack is the sum of the heights of each box. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q10
    {
        public static List<Box> CreateStackDP(List<Box> boxes)
        {
            throw new NotImplementedException();
        }

        public class Box
        {
            public Box(int d, int h, int w)
            {
                this.Width = w;
                this.Height = h;
                this.Depth = d;
            }

            public int Width { get; set; }
            public int Height { get; set; }
            public int Depth { get; set; }

            public bool CanBeAbove(Box box)
            {
                if (box == null)
                    return true;

                return this.Height < box.Height &&
                    this.Width < box.Width &&
                    this.Depth < box.Depth;
            }
        }
    }
}
