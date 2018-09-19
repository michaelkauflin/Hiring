using System;

namespace Exercise
{
    class LinkedList
    {
        public LinkedListNode First { get; private set; }

        public LinkedList(LinkedListNode n)
	    {
	        First = n;
	    }

        public void Revert()
        {
            LinkedListNode previousNode = First;
            LinkedListNode currentNode = First.Next;
            First.Next = null;
            while (currentNode != null)
            {
                LinkedListNode nextNode = currentNode.Next;
                currentNode.Next = previousNode;

                previousNode = currentNode;
                currentNode = nextNode;
            }
            First = previousNode;
        }

        public void PrintList()
        {
            LinkedListNode current = First;
            while (current != null)
            {
                Console.Write(current.Info + " ");
                current = current.Next;
            }
        }
    }
}
