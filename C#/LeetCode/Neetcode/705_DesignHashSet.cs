using System;
using System.Collections;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/majority-element/description/ */
public class MyHashSet
{
    readonly BitArray m_Set = new(1000001);

    public void Add(int key)
    {
        m_Set[key] = true;
    }

    public void Remove(int key)
    {
        m_Set[key] = false;
    }

    public bool Contains(int key)
    {
        return m_Set[key];
    }
}