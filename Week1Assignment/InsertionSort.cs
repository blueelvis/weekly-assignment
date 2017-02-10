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
            int numberOfElements;
            Console.WriteLine("Program to sort numbers using Insertion Sort\n\n");
            Console.WriteLine("Enter the number of elements to sort = \t");
            numberOfElements = int.Parse(Console.ReadLine());

            int[] userElements = new int[numberOfElements];

            for (int i = 0; i < userElements.Length; i++)
            {
                userElements[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
