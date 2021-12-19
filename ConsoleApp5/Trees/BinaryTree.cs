using System.Collections.Generic;

namespace ConsoleApp5.Trees
{
    public class BinaryTree
    {
        private TreeNode root;

        private int pInOrder;
        private int pPostOrder;

        public TreeNode BuildTree(int[] inOrder, int[] postOrder)
        {
            this.pInOrder = inOrder.Length - 1;
            this.pPostOrder = postOrder.Length - 1;

            return this.BuildTree(inOrder, postOrder, null);
        }

        private TreeNode BuildTree(int[] inOrder, int[] postOrder, TreeNode end)
        {
            if (this.pPostOrder < 0)
                return null;

            var node = new TreeNode(postOrder[this.pPostOrder--]);

            if (inOrder[pInOrder] != node.Val)
            {
                node.Right = this.BuildTree(inOrder, postOrder, node);
            }

            pInOrder--;

            if ((end == null) || (end.Val != inOrder[pInOrder]))
            {
                node.Left = this.BuildTree(inOrder, postOrder, end);
            }

            return node;
        }

        public void Insert(int key)
        {
            if (root == null)
            {
                root = new TreeNode(key);
                return;
            }

            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node.Left == null)
                {
                    node.Left = new TreeNode(key);
                    break;
                }

                queue.Enqueue(node.Left);

                if (node.Right == null)
                {
                    node.Right = new TreeNode(key);
                    break;
                }

                queue.Enqueue(node.Right);
            }
        }
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
