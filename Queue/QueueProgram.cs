using System;

namespace QueueProgram
{
    class QueueProgram
    {
        static void Main(string[] args)
        {
            int numberOfElements, i = 0,choice;
            Console.WriteLine("Program exhibiting functionality of Queue\n\n");
            Console.WriteLine("How long do you want the queue? = \t");
            numberOfElements = int.Parse(Console.ReadLine());

            Queue queueObject = new Queue(numberOfElements);

            do
            {
                Console.WriteLine("What would you like to do? \n1. Display Queue \n2. Add Element To Queue \n3. Remove Element from Queue \n4. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        {
                            queueObject.displayQueueContent();
                            break;
                        }
                    case 2:
                        {
                            queueObject.addElementToQueue();
                            break;
                        }
                    case 3:
                        {
                            queueObject.deleteElementFromQueue();
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
        private int[] queue;
        private int currentIndex=-1;

        public Queue(int numberOfElements)
        {
            this.queue = new int[numberOfElements];
        }

        public void addElementToQueue()
        {
            Console.WriteLine("Please Enter The Element = \t");
            int element = int.Parse(Console.ReadLine());
            this.queue[++currentIndex] = element;
            Console.WriteLine("Queue :");
            this.displayQueueContent();
        }

        public void deleteElementFromQueue()
        {
            this.queue[currentIndex--] = 0;
            Console.WriteLine("Queue :");
            this.displayQueueContent();
        }

        public void displayQueueContent()
        {
            Console.WriteLine();
            foreach (int element in queue)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

    }
}
