using System;

namespace BinaryTree
{
    class BinaryTreeProgram
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Program to implement logic of Binary Trees");
            BinaryTree bt = new BinaryTree();
            Node root = null;
            do
            {
                Console.WriteLine("What would you like to do? \n1. Add node to tree \n2. Traverse Tree \n3. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Please Enter the value of the element to insert = \t");
                        int value = int.Parse(Console.ReadLine());
                        root = bt.InsertNode(root,value);
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
        public int value;
        public Node left;
        public Node right;
    }

    class BinaryTree
    {
        public Node InsertNode(Node root, int val)
        {
            if (root == null)
            {
                root = new Node();
                root.value = val;
            }
            else if (val < root.value)
            {
                root.left = InsertNode(root.left, val);
            }
            else
            {
                root.right = InsertNode(root.right, val);
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
                Console.WriteLine(" " + root.value);
            }
            
            TraverseTree(root.left);
            TraverseTree(root.right);
        }
    }
}
