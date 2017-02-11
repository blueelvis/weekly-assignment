using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstSearch
{
    class DepthFirstSearch
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Program to implement logic of DFS using Binary Trees");
            BinaryTree bt = new BinaryTree();
            Node root = null;
            do
            {
                Console.WriteLine("What would you like to do? \n1. Add node to tree \n2. Depth First Search Traversal of Tree \n3. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Please Enter the value of the element to insert = \t");
                            int value = int.Parse(Console.ReadLine());
                            root = bt.InsertNode(root, value);
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
                                bt.DFSTraverseTree(root);
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
        public Node left;
        public Node right;
        public int data;

        public Node(int value, Node left, Node right)
        {
            this.data = value;
            this.left = left;
            this.right = right;
        }

        public Node(int value)
        {
            this.data = value;
            this.left = null;
            this.right = null;
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
            else if (val < root.data)
            {
                root.left = InsertNode(root.left, val);
            }
            else
            {
                root.right = InsertNode(root.right, val);
            }
            return root;
        }

        public void DFSTraverseTree(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.data + " ");
            DFSTraverseTree(root.left);
            DFSTraverseTree(root.right);
        }
    }
}
