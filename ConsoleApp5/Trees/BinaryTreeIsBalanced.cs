using System;

namespace ConsoleApp5.Trees
{
    internal class BinaryTreeIsBalanced
    {
        private int GetHeight(TreeNode root)
        {
            if (root == null)
                return 0;

            return Math.Max(GetHeight(root.Left), GetHeight(root.Right)) + 1;
        }

        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;

            var difference = GetHeight(root.Left) - GetHeight(root.Right);

            if (Math.Abs(difference) > 1)
                return false;
            
            return IsBalanced(root.Left) && IsBalanced(root.Right);
        }
    }
}
