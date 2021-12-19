namespace ConsoleApp5.Trees
{
    internal class SumOfLeftLeaves
    {
        public int Sum(TreeNode root)
        {
            return SumHelper(root.Left, true) + SumHelper(root.Right, false);
        }

        public int SumHelper(TreeNode root, bool isLeft)
        {
            if (root == null)
                return 0;

            var sum = isLeft ? root.Val : 0;

            return sum + SumHelper(root.Left, true) + SumHelper(root.Right, true);
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
