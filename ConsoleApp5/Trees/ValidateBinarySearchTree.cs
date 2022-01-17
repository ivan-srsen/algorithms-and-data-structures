namespace ConsoleApp5.Trees
{
    internal class ValidateBinarySearchTree
    {
        public bool IsTreeValid(TreeNode root)
        {
            return IsValid(root, null, null);
        }

        /// <summary>
        /// Every time we move to the right, we need to set minimum value as root value
        /// Every time we move to the left, we need to set maximum value as root value
        /// That's because current value should never go below it's root if we go right and above it's root if we go left
        /// </summary>
        /// <param name="root">Root node of the tree or subtree</param>
        /// <param name="min">Node of the min value current node should not exceed</param>
        /// <param name="max">Node of the max value current node should not exceed</param>
        /// <returns>A boolean value indicating whether binary search tree is valid</returns>
        private bool IsValid(TreeNode root, TreeNode min, TreeNode max)
        {
            if (root == null)
                return true;

            if (min != null && min.Val > root.Val)
                return false;

            if (max != null && max.Val < root.Val)
                return false;

            return IsValid(root.Left, min, root) && IsValid(root.Right, root, max);
        }
    }
}
