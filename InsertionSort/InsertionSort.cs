using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Assignment
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            int numberOfElements,i=0;
            Console.WriteLine("Program to sort numbers using Insertion Sort\n\n");
            Console.WriteLine("Enter the number of elements to sort = \t");
            numberOfElements = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the elements : \n");
            int[] userElements = new int[numberOfElements];

            for (int j = 0; j < userElements.Length; j++)
            {
                userElements[j] = int.Parse(Console.ReadLine());
            }
            bool didSwap = false;
            do
            {
                if (userElements.Length == 0 || userElements.Length == 1)
                {
                    break;
                }
                didSwap = false;
                for (i = 0; i < userElements.Length; i++)
                {
                    if (i == (userElements.Length - 1))
                    {
                        continue;
                    }
                    if(userElements[i] > userElements[i+1])
                    {
                        int temp = userElements[i];
                        userElements[i] = userElements[i + 1];
                        userElements[i + 1] = temp;
                        didSwap = true;
                    }
                }
            } while (didSwap == true);
            Console.WriteLine("\n\nThe Elements in Sorted order are = \n");
            foreach (int element in userElements)
            {
                Console.WriteLine(element.ToString());
            }
        }
    }
}
