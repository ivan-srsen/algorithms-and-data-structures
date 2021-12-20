using System.Collections.Generic;

namespace ConsoleApp5.Trees
{
    internal class BinaryTreeSerialization
    {
        public string Serialize(TreeNode root)
        {
            if (root == null)
                return "X";

            return root.Val.ToString() + "," +  Serialize(root.Left) + "," + Serialize(root.Right);
        }

        public TreeNode Deserialize(string serialized)
        {
            Queue<string> leftQueue = new Queue<string>();
            var chars = serialized.Split(',');
            foreach(var c in chars)
            {
                leftQueue.Enqueue(c);
            }

            return DeserializeHelper(leftQueue);
        }

        private TreeNode DeserializeHelper(Queue<string> leftQueue)
        {
            var dequeued = leftQueue.Dequeue();

            if (dequeued == "X")
                return null;

            var node = new TreeNode(int.Parse(dequeued));

            node.Left = DeserializeHelper(leftQueue);
            node.Right = DeserializeHelper(leftQueue);

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
