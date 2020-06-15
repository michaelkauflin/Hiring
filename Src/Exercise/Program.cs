using System;
using System.Text;

namespace Exercise
{
    class Program
    {
        // tree -min 1,[2],3,4
        // tree -sum 1,2,3,4
        // linked -revert 1,2,3,4 
        // linked -print 1,2,3,4 
        static int Main(string[] args)
        {
            int count = args.Length;

            if (count < 3)
            {
                Console.Error.WriteLine("Error on commandline");
                Usage();
                
                return -1;
            }
            
            if (!Enum.TryParse(args[0], true, out Option option))
            {
                Console.Error.WriteLine("Error on commandline");
                Usage();

                return -2;
            }
            
            if (!Enum.TryParse(args[1].Trim('-'), true, out SubOption subOption))
            {
                Console.Error.WriteLine("Error on commandline");
                Usage();

                return -2;
            }

            switch (option)
            {
                case Option.Linked:
                {
                    LinkedList linkedList = CreateLinkedList(args[2]);
                    switch (subOption)
                    {
                        case SubOption.Print:
                        {
                            linkedList.PrintList();
                            break;
                        }
                        case SubOption.Revert:
                        {
                            linkedList.Revert();
                            linkedList.PrintList();
                            break;
                        }
                        default:
                        {
                            Usage();
                            break;
                        }
                    }
                    
                    break;
                }
                case Option.Tree:
                {
                    Tree tree = CreateTree(args[2]);
                    switch (subOption)
                    {
                        case SubOption.Min:
                        {
                            Console.WriteLine("Min of tree is: " + tree.Min());
                            break;
                        }
                        case SubOption.Sum:
                        {
                            Console.WriteLine("Sum of tree is: " + tree.Sum());
                            break;
                        }
                        default:
                        {
                            Usage();
                            break;
                        }
                    }
                    break;
                }
            }

            return 0;
        }

        private static Tree CreateTree(string input)
        {
            string[] args = input.Split(',');

            Node rootNode = null;
            Node currentNode = null;
            foreach (string arg in args)
            {
                string item = arg.Trim('[', ']');

                if (!int.TryParse(item, out int value))
                {
                    
                }
                var node = new Node(value);
                
                if (rootNode == null)
                {
                    rootNode = node;
                }
                else
                {
                    if (arg.StartsWith("["))
                    {
                        if (currentNode == null)
                        {
                            rootNode.Left = node;
                        }
                        else
                        {
                            currentNode.Left = node;
                        }
                    }
                    else
                    {
                        if (currentNode == null)
                        {
                            rootNode.Right = node;
                        }
                        else
                        {
                            currentNode.Right = node;
                        }
                    }
                    
                    currentNode = node;
                }
            }
            
            return new Tree(rootNode);
        }

        private static LinkedList CreateLinkedList(string input)
        {
            string[] args = input.Split(',');

            LinkedListNode linkedListNode = null;
            LinkedListNode current = null;
            foreach (string arg in args)
            {
                if (!int.TryParse(arg, out int value))
                {
                    
                }

                var item = new LinkedListNode(value);
                if (linkedListNode == null)
                {
                    linkedListNode = item;
                    current = linkedListNode;
                }
                else
                {
                    current.Next = item;
                    current = item;
                }
            }
            
            return new LinkedList(linkedListNode);
        }

        private static void Usage()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Usage:");
            stringBuilder.AppendLine("* 'tree -sum 1,2,3,4'");
            stringBuilder.AppendLine("* 'tree -min 1,2,3,4'");
            stringBuilder.AppendLine("* 'linked -print 1,2,3,4'");
            stringBuilder.AppendLine("* 'linked -revert 1,2,3,4'");
            
            Console.WriteLine(stringBuilder.ToString());
        }

        private enum Option
        {
            Tree,
            Linked,
        }

        private enum SubOption
        {
            Sum,
            Min,
            Print,
            Revert
        }
    }
}
