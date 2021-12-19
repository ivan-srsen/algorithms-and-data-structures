namespace ConsoleApp5.Trees
{
    //         _______3______
    //        /              \
    //     ___5__          ___1__
    //    /      \        /      \
    //    6      _2       0       8
    //          /  \
    //          7   4

    // Lowest common of 2 and 4 is 2
    // Lowest common of 2 and 6 is 5
    internal class LowestCommonAncestorOfBinaryTree
    {
        public TreeNode FindLowestCommonAncestor(TreeNode root, TreeNode firstNode, TreeNode secondNode)
        {
            if (root == null || root == firstNode || root == secondNode)
                return root;

            var left = FindLowestCommonAncestor(root.Left, firstNode, secondNode);
            var right = FindLowestCommonAncestor(root.Right, firstNode, secondNode);

            if (left != null && right != null)
                return root;

            return left == null ? right : left;
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
