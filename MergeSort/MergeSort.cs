using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int numberOfElements, i = 0;
            Console.WriteLine("Program to sort numbers using Merge Sort\n\n");
            Console.WriteLine("Enter the number of elements to sort = \t");
            numberOfElements = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the elements : \n");
            int[] userElements = new int[numberOfElements];

            for (int j = 0; j < userElements.Length; j++)
            {
                userElements[j] = int.Parse(Console.ReadLine());
            }

        }
    }
}
