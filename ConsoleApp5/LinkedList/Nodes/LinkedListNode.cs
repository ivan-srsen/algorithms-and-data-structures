namespace ConsoleApp5.LinkedList.Nodes
{
    internal class LinkedListNode
    {
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }

        public LinkedListNode(int value)
        {
            this.Value = value;
        }

        public LinkedListNode(int value, LinkedListNode next)
            : this(value)
        {
            this.Next = next;
        }
    }
}
