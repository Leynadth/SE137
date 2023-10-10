using System;

namespace StudentGradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program information
            Console.WriteLine("Student Grade Calculator");
            Console.WriteLine("Date: " + DateTime.Now.ToString("yyyy-MM-dd"));
            Console.WriteLine("Description: Calculate average grade and assign a letter grade.");

            // Gather student information
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            // Gather grades and convert to numeric form
            Console.Write("Enter grade for Assignment 1 (out of 100): ");
            string grade1Input = Console.ReadLine();
            double grade1 = Convert.ToDouble(grade1Input);

            Console.Write("Enter grade for Assignment 2 (out of 100): ");
            string grade2Input = Console.ReadLine();
            double grade2 = Convert.ToDouble(grade2Input);

            Console.Write("Enter grade for Midterm Exam (out of 100): ");
            string midtermInput = Console.ReadLine();
            double midterm = Convert.ToDouble(midtermInput);

            Console.Write("Enter grade for Final Exam (out of 100): ");
            string finalInput = Console.ReadLine();
            double finalExam = Convert.ToDouble(finalInput);

            // Calculate average based on weightings
            double average = (grade1 * 0.20 + grade2 * 0.20 + midterm * 0.25 + finalExam * 0.35);

            // Assign letter grade based on the average
            string letterGrade;
            if (average >= 90)
            {
                letterGrade = "A";
            }
            else if (average >= 80)
            {
                letterGrade = "B";
            }
            else if (average >= 70)
            {
                letterGrade = "C";
            }
            else if (average >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            // Output results
            Console.WriteLine("\nStudent Name: " + studentName);
            Console.WriteLine("Average Grade: " + average.ToString("0.00"));
            Console.WriteLine("Letter Grade: " + letterGrade);

            // Allow the user to see the results before exiting
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
