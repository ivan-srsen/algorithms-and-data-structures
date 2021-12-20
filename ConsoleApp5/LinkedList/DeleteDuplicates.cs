using System.Collections;
using LinkedListNode = ConsoleApp5.LinkedList.Nodes.LinkedListNode;

namespace ConsoleApp5.LinkedList
{
    internal class DeleteDuplicates
    {
        public void Delete(LinkedListNode root)
        {
            var hashTable = new Hashtable();

            var previous = root;
            var current = root.Next;

            while(current != null)
            {
                if (hashTable.ContainsKey(current.Value))
                {
                    previous.Next = current.Next;

                    continue;
                }

                hashTable.Add(current.Value, null);

                previous = current;
                current = current.Next;
            }
        }
    }
}
