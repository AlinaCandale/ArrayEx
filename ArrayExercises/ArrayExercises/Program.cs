using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = { 1, 2, 1, 4, 5 };
            int[] mySecondIntArray = { 1, 20, 56, 18, 3, -7 };
            string[] myStringArray = { "Array", "String", "Stack", "Queue", "Exception", "Operators" };
            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] secondMatrix = new int[3, 3] { { 11, 12, 13 }, { 40, 50, 60 }, { 17, 18, 19 } };
            DisplayArray(myIntArray);
            ReverseArray(myIntArray);
            OccurrencesOfX(myIntArray, 1);
            InsertOnSecondPoz(ref myIntArray, 1986);
            RemoveItem(myIntArray, 1986);
            Console.WriteLine(CalculateSumOfElements(myIntArray));
            SortElem(myIntArray);
            FindAllUniqueElem(myIntArray);
            MergeArrays(myIntArray, mySecondIntArray);
            MaxAndMin(mySecondIntArray);
            OddAndEven(mySecondIntArray);
            SortElemDescending(mySecondIntArray);
            FindSecondLargestElem(mySecondIntArray);
            FindSecondSmallestElem(mySecondIntArray);
            PrintMatrix(matrix);
            AdditionMatrix(matrix, secondMatrix);
        }


        static void DisplayArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine('\n');
            //Write a method to create an array of 5 integers and display the array items. Access individual elements and display them through indexes.
        }


        static void ReverseArray(int[] myArray)
        {
            Array.Reverse(myArray);
            DisplayArray(myArray);
            //Write a method to reverse the order of the items in the array
        }


        static void OccurrencesOfX(int[] myArray, int n)
        {
            Console.WriteLine(Array.FindAll(myArray, element => element == n).Length);
            //Write a method to get the number of occurrences of a specified element in an array
        }


        static void InsertOnSecondPoz(ref int[] myArray, int valueToAdd)
        {
            Array.Resize(ref myArray, myArray.Length + 1);
            for (int i = myArray.Length - 1; i >= 2; i--)
            {
                myArray[i] = myArray[i - 1];
            }
            myArray[1] = valueToAdd;
            DisplayArray(myArray);
            //Write a method to insert a new item before the second element in an existing array
        }


        static void RemoveItem(int[] myArray, int itemToRemove)
        {
            Array.Clear(myArray, Array.IndexOf(myArray, itemToRemove), 1);
            DisplayArray(myArray);
            //Write a method to remove a specified item using the index from an array.
        }


        static int CalculateSumOfElements(int[] myArray)
        {
            int sum = 0;
            foreach (int item in myArray)
            {
                sum += item;
            }
            return sum;
            //Write a program to find the sum of all elements of the array
        }


        static void FindAllUniqueElem(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(myArray[i]);
                }
            }
            //IEnumerable<int> uniqueItems = myArray.Distinct<int>();
            //foreach (var item in uniqueItems)
            //{
            //    Console.WriteLine(item);
            //}
            //Write a program to print all unique elements in an array.
        }


        static void SortElem(int[] myArray)
        {
            Array.Sort(myArray);
            DisplayArray(myArray);
            //Write a program to sort elements of array in ascending order.
        }


        static void MergeArrays(int[] myFirstArray, int[] mySecondArray)
        {
            int[] combined = myFirstArray.Concat(mySecondArray).ToArray();
            SortElem(combined);
            DisplayArray(combined);
            //Write a program to merge two arrays of same size sorted in ascending order.
        }


        static void MaxAndMin(int[] myArray)
        {
            int max = myArray[0];
            int min = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }

                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            Console.WriteLine($"{max} is max and {min} is min in our array");
            //Write a program to find maximum and minimum element in an array.
        }


        static void OddAndEven(int[] myArray)
        {
            int[] oddElemArray = new int[myArray.Length];
            int[] evenElemArray = new int[myArray.Length];
            int j = 0;
            int k = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    evenElemArray[j] = myArray[i];
                    j++;
                }
                else
                {
                    oddElemArray[k] = myArray[i];
                    k++;
                }
            }
            Array.Resize(ref evenElemArray, j);
            Array.Resize(ref oddElemArray, k);
            DisplayArray(evenElemArray);
            DisplayArray(oddElemArray);
            //Write a programin to separate odd and even integers in separate arrays
        }


        static void SortElemDescending(int[] myArray)
        {
            SortElem(myArray);
            Array.Reverse(myArray);
            DisplayArray(myArray);
            //Write a program to sort elements of the array in descending order.
        }


        static void FindSecondLargestElem(int[] myArray)
        {
            SortElemDescending(myArray);
            Console.WriteLine($"Second largest element in array is {myArray[1]}");
            //Write a program to find the second largest element in an array.
        }


        static void FindSecondSmallestElem(int[] myArray)
        {
            SortElem(myArray);
            Console.WriteLine($"Second smallest element in array is {myArray[1]}");
            //Write a program to find the second smallest element in an array.
        }


        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
            //Write a program for a 2D array of size 3x3 and print the matrix.
        }


        static void AdditionMatrix(int[,] matrix1, int[,] matrix2)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] += matrix2[i, j];
                }
            }
            PrintMatrix(matrix1);
            //Write a program in C# Sharp for addition of two Matrices of same size
        }
    }
}
