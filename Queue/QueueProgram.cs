using System;
using System.Collections.Generic;

namespace QueueProgram
{
    class QueueProgram
    {
        static void Main(string[] args)
        {
            int i = 0,choice;
            Console.WriteLine("Program exhibiting functionality of Queue\n\n");
            Console.WriteLine("How long do you want the queue? = \t");
            int numberOfElements = int.Parse(Console.ReadLine());

            Queue queueObject = new Queue(numberOfElements);

            do
            {
                Console.WriteLine("What would you like to do? \n1. Display Queue \n2. Add Element To Queue \n3. Remove Element from Queue \n4. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        {
                            queueObject.DisplayQueueContent();
                            break;
                        }
                    case 2:
                        {
                            queueObject.AddElementToQueue();
                            break;
                        }
                    case 3:
                        {
                            queueObject.DeleteElementFromQueue();
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
    }
    class Queue
    {
        private Queue<string> _queue;
        public Queue(int maxSize)
        {
            _queue = new Queue<string>(maxSize);
        }

        public void AddElementToQueue()
        {
            Console.WriteLine("Please Enter The Element = \t");
            string input = Console.ReadLine();
            _queue.Enqueue(input);
            Console.WriteLine("Queue :");
            this.DisplayQueueContent();
        }

        public void DeleteElementFromQueue()
        {
            _queue.Dequeue();
            Console.WriteLine("Queue :");
            DisplayQueueContent();
        }

        public void DisplayQueueContent()
        {
            Console.WriteLine();
            foreach (string element in _queue)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

    }
}
