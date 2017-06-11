using System;
using System.Linq;
namespace LeetSharp
{
    class TreeNode 
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
 
    partial class Program
    {
        public static string Tree2str(TreeNode t) 
        {
            if (t == null)
                return "";
            if (t.left == null && t.right == null)
                return t.val.ToString();
            return $"{t.val}({Tree2str(t.left)}){(t.right == null ? "" : $"({Tree2str(t.right)})")}";
        }
    }
}