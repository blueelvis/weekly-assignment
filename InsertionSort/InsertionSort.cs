using System;
using System.Globalization;

namespace InsertionSort
{
    class InsertionSortClass
    {
        static void Main()
        {
            int numberOfElements;
            Console.WriteLine("Program to sort numbers using Insertion Sort\n\n");
            Console.WriteLine("Enter the number of elements to sort = \t");
            if (int.TryParse(Console.ReadLine(), out numberOfElements))
            {
                Console.WriteLine("Please Enter the elements : \n");
                double[] userElements = new double[numberOfElements];

                for (int j = 0; j < userElements.Length; j++)
                {
                    double tmp;
                    if (double.TryParse(Console.ReadLine(),out tmp))
                    {
                        userElements[j] = tmp;
                    }
                    
                }
                userElements = InsertionSort(userElements);
                PrintArray(userElements);
            }
            else
            {
                Console.WriteLine("Invalid Input entered. Please try again.");
            }
        }

        public static void PrintArray(double[] userElements)
        {
            Console.WriteLine("\n\nThe Elements in Sorted order are = \n");
            foreach (double element in userElements)
            {
                Console.WriteLine(element.ToString(CultureInfo.CurrentCulture));
            }
        }

        public static double[] InsertionSort(double[] userElements)
        {
            int i;
            bool didSwap;
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
                    if (userElements[i] > userElements[i + 1])
                    {
                        double temp = userElements[i];
                        userElements[i] = userElements[i + 1];
                        userElements[i + 1] = temp;
                        didSwap = true;
                    }
                }
            } while (didSwap == true);
            return userElements;
        }
    }
}
