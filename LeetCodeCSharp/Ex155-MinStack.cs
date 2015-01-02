/*
Design a stack that supports push, pop, top, and retrieving 
the minimum element in constant time. 
• push(x) -- Push element x onto stack. 
• pop() -- Removes the element on top of the stack. 
• top() -- Get the top element. 
• getMin() -- Retrieve the minimum element in the stack. 

class MinStack {
public:
    void push(int x) {
        
    }

    void pop() {
        
    }

    int top() {
        
    }

    int getMin() {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex155
    {
        public class MinStack
        {
            private Stack<int> stk = new Stack<int>();
            private Stack<int> mins = new Stack<int>();

            public void Push(int x)
            {
                throw new NotImplementedException();
            }

            public int Pop()
            {
                throw new NotImplementedException();
            }

            public int Top()
            {
                throw new NotImplementedException();
            }

            public int GetMin()
            {
                throw new NotImplementedException();
            }
        }
    }
}