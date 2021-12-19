namespace ConsoleApp5.Trees
{
    internal class IsSubtree
    {
        public bool IsSubtree(TreeNode root1, TreeNode root2)
        {

        }

        private bool SubTree(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
                return false;

            if(root1.Val == root2.Val)
            {
                return MatchTree(root1, root2);
            }

            return SubTree(root1.Left, root2) || SubTree(root1.Right, root2);
        }

        private bool MatchTree(TreeNode root1, TreeNode root2)
        {
            if ((root1 == null && root2 != null) || (root1 != null && root2 == null))
                return false;

            if (root1.Val != root2.Val)
                return false;

            return MatchTree(root1.Left, root2.Left) && MatchTree(root1.Right, root2.Right);
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
