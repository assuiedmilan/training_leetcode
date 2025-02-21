using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/min-stack/description/ */
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
