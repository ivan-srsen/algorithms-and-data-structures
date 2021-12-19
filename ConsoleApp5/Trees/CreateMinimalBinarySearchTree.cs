namespace ConsoleApp5.Trees
{
    internal class CreateMinimalBinarySearchTree
    {
        public TreeNode Create(int[] array)
        {
            return CreateMinimalBST(array, 0, array.Length - 1);
        }

        private TreeNode CreateMinimalBST(int[] array, int start, int end)
        {
            if (start > end)
                return null;

            var mid = (start + end) / 2;

            var node = new TreeNode(mid);

            node.Left = CreateMinimalBST(array, start, mid - 1);
            node.Right = CreateMinimalBST(array, mid + 1, end);

            return node;
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
