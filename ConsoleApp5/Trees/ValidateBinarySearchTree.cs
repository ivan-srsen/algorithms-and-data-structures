namespace ConsoleApp5.Trees
{
    internal class ValidateBinarySearchTree
    {
        public bool IsBstValid(TreeNode root)
        {
            if (root == null)
                return true;

            if (root.Left != null && root.Left.Val < root.Val)
                return true;

            if (root.Right != null && root.Right.Val > root.Val)
                return true;

            return IsBstValid(root.Left) && IsBstValid(root.Right);
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
