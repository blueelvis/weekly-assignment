using System;
using System.Collections.Generic;
using System.Globalization;

namespace MergeSort
{
    class MergeSortClass
    {
        static void Main()
        {
            int numberOfElements;
            Console.WriteLine("Program to sort numbers using Merge Sort\n\n");
            Console.WriteLine("Enter the number of elements to sort = \t");
            if (int.TryParse(Console.ReadLine(), out numberOfElements))
            {
                Console.WriteLine("Please Enter the elements : \n");
                double[] userElements = new double[numberOfElements];

                for (int j = 0; j < numberOfElements; j++)
                {
                    double tmp;
                    if (double.TryParse(Console.ReadLine(), out tmp))
                    {
                        userElements[j] = tmp;
                    }
                }
                userElements = MergeSort(userElements);
                Console.WriteLine("\n\nThe Elements in Sorted order are = \n");
                foreach (double element in userElements)
                {
                    Console.WriteLine(element.ToString(CultureInfo.CurrentCulture));
                }
            }
            else
            {
                Console.WriteLine("Invalid Input entered. Please try again.");
            }

        }

        public static double[] MergeSort(double[] array)
        {
            // If list size is 0 (empty) or 1, consider it sorted and return it
            // (using less than or equal prevents infinite recursion for a zero length array).
            if (array.Length <= 1)
            {
                return array;
            }

            // Else list size is > 1, so split the list into two sublists.
            int middleIndex = (array.Length) / 2;
            double[] left = new double[middleIndex];
            double[] right = new double[array.Length - middleIndex];

            Array.Copy(array, left, middleIndex);
            Array.Copy(array, middleIndex, right, 0, right.Length);

            // Recursively call MergeSort() to further split each sublist
            // until sublist size is 1.
            left = MergeSort(left);
            right = MergeSort(right);

            // Merge the sublists returned from prior calls to MergeSort()
            // and return the resulting merged sublist.
            return Merge(left, right);
        }

        public static double[] Merge(double[] left, double[] right)
        {
            // Convert the input arrays to lists, which gives more flexibility 
            // and the option to resize the arrays dynamically.
            List<double> leftList = new List<double>(left);
            List<double> rightList = new List<double>(right);
            List<double> resultList = new List<double>();

            // While the sublist are not empty merge them repeatedly to produce new sublists 
            // until there is only 1 sublist remaining. This will be the sorted list.
            while (leftList.Count > 0 || rightList.Count > 0)
            {
                if (leftList.Count > 0 && rightList.Count > 0)
                {
                    // Compare the 2 lists, append the smaller element to the result list
                    // and remove it from the original list.
                    if (leftList[0] <= rightList[0])
                    {
                        resultList.Add(leftList[0]);
                        leftList.RemoveAt(0);
                    }

                    else
                    {
                        resultList.Add(rightList[0]);
                        rightList.RemoveAt(0);
                    }
                }

                else if (leftList.Count > 0)
                {
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }

                else if (rightList.Count > 0)
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }

            // Convert the resulting list back to a static array
            double[] result = resultList.ToArray();
            return result;
        }

    }
}
