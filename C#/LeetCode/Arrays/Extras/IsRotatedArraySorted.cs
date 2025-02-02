namespace LeetCode.Arrays.Extras;

public class IsRotatedArraySorted
{
    public bool Solution(int[] nums)
    {
        var decreasedOnce = false;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                if (decreasedOnce) return false;
                decreasedOnce = true;
            }
        }

        return !decreasedOnce || nums[0] >= nums[^1];
    } 
}
