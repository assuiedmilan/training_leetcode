namespace LeetCode.Arrays.Extras;

public class MaximumAscendingSubarraySum
{
    public int Solution(int[] nums)
    {
        var result = nums[0];
        var runningSum = result;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] < nums[i])
            {
                var potentialRunningSum = runningSum + nums[i];
                runningSum = potentialRunningSum > runningSum ? potentialRunningSum : nums[i];
            }
            else
            {
                result = result > runningSum ? result : runningSum;
                result = nums[i-1] > result ? nums[i-1] : result;
                runningSum = nums[i];
            }
        }
        
        return result > runningSum ? result : runningSum;
    }    
}
