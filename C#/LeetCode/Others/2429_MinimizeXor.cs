namespace LeetCode.Others;

/* https://leetcode.com/problems/minimize-xor/ */
public class MinimizeXor
{
    bool[] m_FlippedBitsTracker;
    int m_RemainingBitsToFlip;
    
    public int Solution(int num1, int num2)
    {
        m_FlippedBitsTracker = new bool[32];
        m_RemainingBitsToFlip = CountSetBits(num2);

        var result = 0;

        for (var i = m_FlippedBitsTracker.Length - 1; i >= 0 && m_RemainingBitsToFlip > 0; i--)
        {
            num1 = FlipBit(num1, i, true);
        }
        
        for (var i = 0; i < m_FlippedBitsTracker.Length && m_RemainingBitsToFlip > 0; i++)
        {
            if (!m_FlippedBitsTracker[i]) num1 = FlipBit(num1, i, false);
        }

        for (var i = 0; i < m_FlippedBitsTracker.Length; i++)
        {
            if (m_FlippedBitsTracker[i]) result |= 1 << i;
        }
        
        return result;
    }
    
    static int CountSetBits(int bitmask)
    {
        var count = 0;

        while (bitmask != 0)
        {
            count += bitmask & 1;
            bitmask >>= 1;
        }

        return count;
    }
    
    int FlipBit(int bitmask, int i, bool flipIfSet)
    {
        var isBitSet = (bitmask & (1 << i)) != 0;

        if (isBitSet == flipIfSet)
        {
            bitmask ^= 1 << i;
            m_FlippedBitsTracker[i] = true;
            m_RemainingBitsToFlip--;
        }

        return bitmask;
    }
}
