using System;
using System.Collections.Generic;

namespace BreadthFirstSearch
{
    class BreadthFirstSearch
    {
        static void Main()
        {
            int choice;
            Console.WriteLine("Program to implement logic of BFS using Binary Trees");
            BinaryTree bt = new BinaryTree();
            Node root = null;
            do
            {
                Console.WriteLine("What would you like to do? \n1. Add node to tree \n2. Breadth First Search Traversal of Tree \n3. Exit");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Please Enter the value of the element to insert = \t");
                            var input = Console.ReadLine();
                            int value;
                            if (input != null && int.TryParse(input, out value))
                            {
                                value = int.Parse(input);
                                root = bt.InsertNode(root, value);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input entered. Please try again.");
                            }
                            break;
                        }
                    case 2:
                        {
                            if (root == null)
                            {
                                Console.WriteLine("The tree is empty :(");
                            }
                            else
                            {
                                bt.BFSTraverseTree(root);
                            }

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice!");
                            break;
                        }
                }
            } while (choice != 3);
        }
    }

    class Node
    {
        public Node Left;
        public Node Right;
        public int Data;

        public Node(int value,Node left, Node right)
        {
            Data = value;
            Left = left;
            Right = right;
        }

        public Node(int value)
        {
            Data = value;
            Left = null;
            Right = null;
        }
    }

    class BinaryTree
    {
        public Node InsertNode(Node root, int val)
        {
            if (root == null)
            {
                root = new Node(val);
            }
            else if (val < root.Data)
            {
                root.Left = InsertNode(root.Left, val);
            }
            else
            {
                root.Right = InsertNode(root.Right, val);
            }
            return root;
        }

        public void BFSTraverseTree(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                root = queue.Dequeue();
                Console.WriteLine(root.Data + " ");

                if (root.Left != null)
                {
                    queue.Enqueue(root.Left);
                }
                if (root.Right!= null)
                {
                    queue.Enqueue(root.Right);
                }
            }
        }
    }
}
