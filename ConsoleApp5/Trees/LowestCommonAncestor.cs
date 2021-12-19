using ConsoleApp5.Graphs;

namespace ConsoleApp5.Trees
{
    public class LowestCommonAncestor
    {
        private TreeNode root;
        

        public class TreeNode
        {
            public int Val;
            public Trees.TreeNode Left;
            public Trees.TreeNode Right;
            public TreeNode(int val = 0, Trees.TreeNode left = null, Trees.TreeNode right = null)
            {
                this.Val = val;
                this.Left = left;
                this.Right = right;
            }
        }
    }
}
