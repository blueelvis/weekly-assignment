using System;

namespace Stack
{
    class StackProgram
    {
        static void Main()
        {
            int numberOfElements;
            Console.WriteLine("Program exhibiting functionality of Stack\n\n");
            Console.WriteLine("How big do you want the Stack? = \t");
            if (int.TryParse(Console.ReadLine(), out numberOfElements))
            {
                Stack stackObject = new Stack(numberOfElements);
                int choice;
                do
                {
                    Console.WriteLine(
                        "What would you like to do? \n1. Display Stack \n2. Add Element To Stack \n3. Remove Element from Stack \n4. Exit");
                    int.TryParse(Console.ReadLine(), out choice);
                    switch (choice)
                    {
                        case 1:
                        {
                            stackObject.DisplayStackContent();
                            break;
                        }
                        case 2:
                        {
                            stackObject.AddElementToStack();
                            break;
                        }
                        case 3:
                        {
                            stackObject.DeleteElementFromStack();
                            break;
                        }
                        case 4:
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
                } while (choice != 4);
            }
            else
            {
                Console.WriteLine("Invalid Input. Please Try Again.");
            }
        }
        
    }

    class Stack
    {
        private string[] _stack;
        private int _currentIndex = -1;

        public Stack(int numberOfElements)
        {
            _stack = new string[numberOfElements];
        }

        public void AddElementToStack()
        {
            Console.WriteLine("Please Enter The Element = \t");
            string input = Console.ReadLine();
            _stack[++_currentIndex] = input;
            Console.WriteLine("Stack :");
            DisplayStackContent();
        }

        public void DeleteElementFromStack()
        {
            _stack[_currentIndex--] = null;
            Console.WriteLine("Stack :");
            DisplayStackContent();
        }

        public void DisplayStackContent()
        {
            Console.WriteLine();
            foreach (string element in _stack)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

    }
}
