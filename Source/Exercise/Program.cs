using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLinkedList();
            Console.ReadLine();
        }

        static void TestTree()
        {
            var n = new Node(4);
            n.Right = new Node(5);
            n.Right.Left = new Node(10);
            n.Left = new Node(1);
            n.Left.Right = new Node(2);

            var t = new Tree(n);
            Console.WriteLine("Sum is " + t.Sum());
            Console.WriteLine("Min is " + t.Min());
        }

        static void TestLinkedList()
        {
            var n1 = new LinkedListNode(1);
            var n2 = new LinkedListNode(2);
            var n3 = new LinkedListNode(3);
            var n4 = new LinkedListNode(4);
            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            var list = new LinkedList(n1);
            Console.Write("List before reversing: ");
            list.PrintList();
            Console.WriteLine("\n");
            list.Revert();
            Console.WriteLine("List after reverting: ");
            list.PrintList();
        }

        public int ArraySum(int[] a)
        {
            var result = 0;
            foreach (var i in a)
            {
                result = result + i;
            }
            return result;
        }
    }
}
