using LinkedListNode = ConsoleApp5.LinkedList.Nodes.LinkedListNode;

namespace ConsoleApp5.LinkedList
{
    internal class DeleteNode
    {
        public void Delete(LinkedListNode node)
        {
            if (node == null || node.Next == null)
                return;

            var next = node.Next;
            node.Value = next.Value;
            node.Next = next.Next;
        }
    }
}
