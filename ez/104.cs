using System;
using System.Linq;
namespace LeetSharp
{
    partial class Program
    {
        public int MaxDepth(TreeNode root) {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;
            var left = 0;
            var right = 0;
            if (root.left != null)
                left = MaxDepth(root.left) + 1;
            if (root.right != null)
                right = MaxDepth(root.right) + 1;
            return Math.Max(left, right);
        }
    }
}