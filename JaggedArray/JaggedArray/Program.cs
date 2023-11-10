// See https://aka.ms/new-console-template for more information
using System;
namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {// Task 1: Declaration and Initialization
            int[][] matrix = new int[][]
            {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6 },
            new int[] { 7, 8, 15 }
            };

            // Task 2: Accessing and Display
            // Access and store the value of the second element in the first row
            int element = matrix[0][1];

            Console.WriteLine("Task 2: Display the entire matrix using nested loop");
            foreach (var row in matrix)
            {
                foreach (var item in row)
                {
                    Console.Write(item + " ");
                }
                // Move to the next line for the next row
                Console.WriteLine();
            }

            Console.WriteLine("\nTask 3: Modify the third element in the second row to have a value of 15");
            // Modify the third element in the second row
            if (matrix.Length > 1 && matrix[1].Length > 2)
            {
                matrix[1][2] = 15; // Modify the third element in the second row
            }
            else
            {
                Console.WriteLine("Unable to modify. Insufficient elements in the second row.");
            }

            // Task 4: Advanced Concepts using dynamic datatype
            dynamic[][] objectMatrix = new dynamic[][]
            {
            new dynamic[] { 10, "Hello", 3.14 },
            new dynamic[] { true, 'A', DateTime.Now }
            };

            Console.WriteLine("\nTask 4: Display the contents of the objectMatrix using nested loops");
            foreach (var row in objectMatrix)
            {
                foreach (var item in row)
                {
                    Console.Write($"Type: {item.GetType().Name}, Value: {item} | ");
                }
                // Move to the next line for the next row
                Console.WriteLine();
            }
        }
    }
}

