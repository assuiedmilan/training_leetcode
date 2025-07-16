namespace LeetCode.Gen;

// https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
// 104. Maximum Depth of Binary Tree

public class MaximumDepthBinaryTree104
{
    public int MaxDepth(TreeNode root)
    {
        var maxDepth = 0;
        var currentDepth = 0;
        while (root.left != null)
        {
            currentDepth += 1;
        }

        return 0;
    }
}
