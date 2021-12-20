namespace ConsoleApp5.Trees
{
    internal class SymmetricBinaryTree
    {
        public bool IsBinaryTreeSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            return Check(root.Left, root.Right);
        }

        private bool Check(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;

            if(left != null && right != null)
            {
                return left.Val == right.Val && Check(left.Right, right.Left) && Check(right.Left, left.Right);
            }

            return false;
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
