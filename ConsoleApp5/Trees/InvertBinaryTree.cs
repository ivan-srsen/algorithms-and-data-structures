namespace ConsoleApp5.Trees
{
    internal class InvertBinaryTree
    {
        public TreeNode Invert(TreeNode root)
        {
            if (root.Left == null && root.Right == null)
                return null;

            var left = root.Left;
            var right = root.Right;

            root.Left = Invert(left);
            root.Right = Invert(right);

            return root;
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
