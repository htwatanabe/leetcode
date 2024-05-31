/*
 * @lc app=leetcode id=104 lang=csharp
 *
 * [104] Maximum Depth of Binary Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    // No recursion
    public int MaxDepth(TreeNode root) {
        var ret = 0;
        var stack = new Stack<(TreeNode, int)>();
        stack.Push((root, 0));
        while (stack.Count > 0) {
            var (currentNode, parentDepth) = stack.Pop();
            if (currentNode == null) continue;
            var currentDepth = parentDepth + 1;
            if (currentDepth > ret) ret = currentDepth;
            stack.Push((currentNode.left, currentDepth));
            stack.Push((currentNode.right, currentDepth));
        }
        return ret;
    }

    // Recursion
    public int MaxDepthR(TreeNode root) {
        int ret = 0;
        void dfs(TreeNode node, int depth) {
            if (node == null) return;
            var currentDepth = depth + 1;
            if (currentDepth > ret) ret = currentDepth;
            dfs(node.left, currentDepth);
            dfs(node.right, currentDepth);
        }
        dfs(root, ret);
        return ret;
    }
}

// @lc code=end

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}