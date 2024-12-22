namespace LeetCode.Arrays.Extras;

public class RemoveElement
{
    public int Solution(int[] nums, int val) {
        var i = 0;
        for (var j = 0; j < nums.Length; j++)
        {
            if (nums[j] == val) continue;
            nums[i++] = nums[j];
        }
        return i;
    }
}