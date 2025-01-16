using System.Collections.Generic;

namespace LeetCode.Stack.NeetCode150;

/*
 * Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
 *
 * Implement the MinStack class:
 *
 *     MinStack() initializes the stack object.
 *     void push(int val) pushes the element val onto the stack.
 *     void pop() removes the element on the top of the stack.
 *     int top() gets the top element of the stack.
 *     int getMin() retrieves the minimum element in the stack.
 *
 * You must implement a solution with O(1) time complexity for each function.
 *
 *
 *
 * Example 1:
 *
 * Input
 * ["MinStack","push","push","push","getMin","pop","top","getMin"]
 * [[],[-2],[0],[-3],[],[],[],[]]
 *
 * Output
 * [null,null,null,null,-3,null,0,-2]
 *
 * Explanation
 * MinStack minStack = new MinStack();
 * minStack.push(-2);
 * minStack.push(0);
 * minStack.push(-3);
 * minStack.getMin(); // return -3
 * minStack.pop();
 * minStack.top();    // return 0
 * minStack.getMin(); // return -2
 *
 *
 *
 * Constraints:
 *
 *     -231 <= val <= 231 - 1
 *     Methods pop, top and getMin operations will always be called on non-empty stacks.
 *     At most 3 * 104 calls will be made to push, pop, top, and getMin.
 *
 *
 */
public class MinStack
{
    Stack<int> m_Stack = new();
    Stack<int[]> m_MinimumStack = new();

    int m_CurrentMin;
    int m_CurrentMinCount;

    public void Push(int val)
    {
        if (m_Stack.Count == 0)
        {
            m_CurrentMin = val;
            m_CurrentMinCount = 1;
        }
        
        m_Stack.Push(val);
        
        if(val < m_CurrentMin)
        {
            m_MinimumStack.Push([m_CurrentMin, m_CurrentMinCount]);
            m_CurrentMin = val;
            m_CurrentMinCount = 1;
            return;
        }

        m_CurrentMinCount++;
    }

    public void Pop()
    {
        m_Stack.Pop();
        m_CurrentMinCount--;

        if (m_CurrentMinCount == 0)
        {
            var newMinimums = m_MinimumStack.Pop();
            m_CurrentMin = newMinimums[0];
            m_CurrentMinCount = newMinimums[1];
        }
    }
    
    public int Top()
    {
        return m_Stack.Peek();        
    }
    
    public int GetMin()
    {
        return m_CurrentMin;        
    }
}
