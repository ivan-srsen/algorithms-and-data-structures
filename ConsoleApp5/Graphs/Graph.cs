using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp5.Graphs
{
    internal class Graph
    {
        public void BreadthFirst(Node root)
        {
            if (root == null)
                return;

            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                var node = queue.Dequeue();
                Console.WriteLine(node.Value);

                foreach(var nNode in node.Nodes)
                {
                    queue.Enqueue(nNode);
                }
            }
        }

        public bool HasPath(Node source, Node destination)
        {
            if (source == null || destination == null)
                return false;

            var hashTable = new Hashtable();
            var queue = new Queue<Node>();

            queue.Enqueue(source);

            while(queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node == destination)
                    return true;

                foreach(var nNode in node.Nodes)
                {
                    if (hashTable.ContainsKey(nNode))
                        continue;

                    queue.Enqueue(nNode);
                }

                hashTable.Add(node, null);
            }

            return false;
        }

        public void DepthFirst(Node root)
        {
            if (root == null)
                return;

            var stack = new Stack<Node>();
            stack.Push(root);

            while(stack.Count > 0)
            {
                var node = stack.Pop();

                Console.WriteLine(node.Value);

                foreach (var nNode in node.Nodes)
                {
                    stack.Push(nNode);
                }
            }
        }

        public class Node
        {
            public int Value;
            public List<Node> Nodes { get; set; } = new List<Node>();
        }
    }
}
