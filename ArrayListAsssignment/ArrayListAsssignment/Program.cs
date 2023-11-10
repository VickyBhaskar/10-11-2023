// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
namespace ArrayListAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: ArrayList Initialization and Population
            ArrayList studentGrades = new ArrayList();
            studentGrades.Add(85);
            studentGrades.Add(92);
            studentGrades.Add(78);
            studentGrades.Add(95);
            studentGrades.Add(88);

            // Task 2: Display and Sum
            Console.WriteLine("Task 2.1: Display the contents of studentGrades using a loop.");
            foreach (var grade in studentGrades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine("\nTask 2.2: Calculate and display the sum of all the grades in studentGrades.");
            int sum = 0;
            foreach (var grade in studentGrades)
            {
                sum += (int)grade;
            }
            Console.WriteLine("Sum of grades: " + sum);

            // Task 3: Grade Addition
            Console.WriteLine("\nTask 3.1: Add a new grade of 90 to the end of studentGrades.");
            studentGrades.Add(90);

            Console.WriteLine("Task 3.2: Display the updated contents of studentGrades after the addition.");
            foreach (var grade in studentGrades)
            {
                Console.WriteLine(grade);
            }

            // Task 4: Grade Removal
            Console.WriteLine("\nTask 4.1: Remove the grade of 78 from studentGrades.");
            studentGrades.Remove(78);

            Console.WriteLine("Task 4.2: Display the contents of studentGrades after the removal.");
            foreach (var grade in studentGrades)
            {
                Console.WriteLine(grade);
            }

            // Task 5:Search and  Update
            Console.WriteLine("\nTask 5.1: Search for the index of the grade 95 in studentGrades.");
            int indexOfGrade95 = studentGrades.IndexOf(95);
            Console.WriteLine("\nIndex of Grade 95 : \t "+ indexOfGrade95);
            if (indexOfGrade95 != -1)
            {
                Console.WriteLine("Task 5.2: Update the grade at the found index to 96.");
                studentGrades[indexOfGrade95] = 96;
            }

            Console.WriteLine("Updated contents of studentGrades:");
            foreach (var grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}

