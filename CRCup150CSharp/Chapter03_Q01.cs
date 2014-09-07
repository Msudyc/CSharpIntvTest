/* Question 3.1
 
Describe how you could use a single array to implement three stacks.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter03_Q01
    {
        public class FixedSizeStacks
        {
            private const int StackSize = 100;
            private int[] buffer = new int[StackSize * 3];
            private int[] stackPointer = { -1, -1, -1 };

            public void Push(int stackNum, int value)
            {
                throw new NotImplementedException();
            }

            public int Pop(int stackNum)
            {
                throw new NotImplementedException();
            }

            public int Peek(int stackNum)
            {
                throw new NotImplementedException();
            }

            public bool IsEmpty(int stackNum)
            {
                throw new NotImplementedException();
            }

            private int absTopOfStack(int stackNum)
            {
                throw new NotImplementedException();
            }
        }
    }
}
