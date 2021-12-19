using System;

namespace ConsoleApp5.Trees
{
    internal class BinaryTreeMaxPathSum
    {
        private TreeNode root;

        public int MaxPathSum()
        {
            return MaxPathSum(root);
        }

        private int MaxPathSum(TreeNode currentNode)
        {
            if (currentNode == null)
                return 0;

            int max = 0;

            var leftResult = MaxPathSum(currentNode.Left);
            var rightResult = MaxPathSum(currentNode.Right);

            return Math.Max(leftResult, rightResult) + currentNode.Val;
        }

        public class TreeNode
        {
            public int Val;
            public TreeNode Left;
            public TreeNode Right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.Val = val;
                this.Left = left;
                this.Right = right;
            }
        }
    }
}
