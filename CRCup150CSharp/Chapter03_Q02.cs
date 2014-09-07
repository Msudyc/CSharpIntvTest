/* Question 3.2
 
How would you design a stack which in addition to push and pop, also has a function min 
which returs the minimum element? Push, pop and min should all operate in O(1) time.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter03_Q02
    {
        public class StackWithMin : Stack<int>
        {
            private Stack<int> minStack = new Stack<int>();

            public new void Push(int value)
            {
                throw new NotImplementedException();
            }

            public new int Pop()
            {
                throw new NotImplementedException();
            }

            public int Min()
            {
                throw new NotImplementedException();
            }
        }
    }
}
