using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp5.Trees
{
    public class BinarySearchTree
    {
        private TreeNode root;

        public void Insert(int value)
        {
            root = Insert(root, value);
        }

        private TreeNode Insert(TreeNode root, int value)
        {
            if (root == null)
                return new TreeNode(value);

            if (value < root.Val)
                root.Left = Insert(root.Left, value);
            else
                root.Right = Insert(root.Right, value);

            return root;
        }

        public void Remove(int key)
        {
            root = Remove(root, key);
        }

        public TreeNode Remove(TreeNode root, int key)
        {
            if (root == null)
                return null;

            if(key < root.Val)
                return root.Left = Remove(root.Left, key);
            else if(key > root.Val)
                return root.Right = Remove(root.Right, key);

            if (root.Left == null)
                return root.Right;

            if (root.Right == null)
                return root.Left;

            root.Val = FindMin(root.Right);

            root.Right = Remove(root.Right, root.Val);

            return root;
        }

        private int FindMin(TreeNode root)
        {
            var current = root;

            while(current.Left != null)
            {
                current = current.Left;
            }

            return current.Val;
        }

        public void InOrderTraversal() => InOrderTraversal(this.root);

        private void InOrderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            InOrderTraversal(node.Left);
            Console.WriteLine(node.Val);
            InOrderTraversal(node.Right);
        }

        private void PostOrderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.WriteLine(node.Val);
        }

        public int MaxPath() => MaxPath(this.root);

        public int MaxPath(TreeNode node)
        {
            if (node == null)
                return 0;

            var currentResult = node.Val + (node.Left?.Val ?? 0)  + (node.Right?.Val ?? 0);
            
            var nodeLeftResult = MaxPath(node.Left);
            var nodeRightResult = MaxPath(node.Right);

            if (nodeLeftResult > currentResult)
                currentResult = nodeLeftResult;

            if (nodeRightResult > currentResult)
                currentResult = nodeRightResult;

            return currentResult;
        }

        public int CheckNumTrees(int n)
        {
            var result = 0;

            if (n <= 1)
                return 1;

            for (var i = 0; i < n; i++)
            {
                result += CheckNumTrees(i) * CheckNumTrees(n - i - 1);
            }

            return result;
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
