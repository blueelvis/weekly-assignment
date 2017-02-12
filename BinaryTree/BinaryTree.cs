using System;

namespace BinaryTree
{
    class BinaryTreeProgram
    {
        static void Main()
        {
            int choice;
            Console.WriteLine("Program to implement logic of Binary Trees");
            BinaryTree bt = new BinaryTree();
            Node root = null;
            do
            {
                Console.WriteLine("What would you like to do? \n1. Add node to tree \n2. Traverse Tree \n3. Exit");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Please Enter the value of the element to insert = \t");
                        var input = Console.ReadLine();
                        int value;
                            if (input != null && int.TryParse(input,out value))
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
                                bt.TraverseTree(root);
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
        public int Value;
        public Node Left;
        public Node Right;
    }

    class BinaryTree
    {
        public Node InsertNode(Node root, int val)
        {
            if (root == null)
            {
                root = new Node();
                root.Value = val;
            }
            else if (val < root.Value)
            {
                root.Left = InsertNode(root.Left, val);
            }
            else
            {
                root.Right = InsertNode(root.Right, val);
            }
            return root;
        }

        public void TraverseTree(Node root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(" " + root.Value);
            }
            
            TraverseTree(root.Left);
            TraverseTree(root.Right);
        }
    }
}
