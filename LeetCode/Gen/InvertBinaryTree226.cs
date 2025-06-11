using System.Collections.Generic;

namespace LeetCode.Gen;

// 226. Invert Binary Tree

public class InvertBinaryTree226
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;
        if(root.left == null && root.right == null) return root;

        var temp = root.left;
        root.left = InvertTree(root.right);
        root.right = InvertTree(temp);

        return root;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
