using System;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLinkedList();
            TestTree();
            ArraySum(new[] { 1, 2, 3, 4 });
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
            Console.WriteLine("\n");
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
            Console.WriteLine("List before reversing: ");
            list.PrintList();
            list.Revert();
            Console.WriteLine("\nList after reverting: ");
            list.PrintList();
            Console.WriteLine("\n");
        }

        static void ArraySum(IEnumerable<int> a)
        {
            var result = 0; 
            foreach (var i in a)
            {
                result = result + i;
            }
            Console.WriteLine("Sum is " + result); 
            Console.WriteLine("\n");
        }
    }
}
