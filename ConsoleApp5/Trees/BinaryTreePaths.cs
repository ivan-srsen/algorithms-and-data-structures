using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5.Trees
{
    public class BinaryTreePaths
    {
        private TreeNode root;

        public IEnumerable<IEnumerable<int>> GetPaths(TreeNode currentNode, List<int> currentPath)
        {
            if(currentNode == null)
                return new List<IEnumerable<int>>();

            if (currentNode.Left == null && currentNode.Right == null)
                return new List<IEnumerable<int>> { currentPath };

            currentPath.Add(currentNode.Val);

            if (currentNode.Right == null && currentNode.Left != null)
                return GetPaths(currentNode.Left, currentPath);

            if(currentNode.Right != null && currentNode.Left == null)
                return GetPaths(currentNode.Right, currentPath);

            var pathRight = GetPaths(currentNode.Right, currentPath);
            pathRight.ToList().AddRange(GetPaths(currentNode.Left, currentPath));

            return pathRight;
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
