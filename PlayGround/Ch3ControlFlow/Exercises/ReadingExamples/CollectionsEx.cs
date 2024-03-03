using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Ch3ControlFlow.Exercises.ReadingExamples
{
    internal class CollectionsEx
    {
        public static void ListExamples()
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;
            string input;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names
            do
            {
                input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    students.Add(newStudent);
                }

            } while (!Equals(newStudent, ""));

            // Get student grades
            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                input = Console.ReadLine();
                double grade = double.Parse(input);
                grades.Add(grade);
            }

            // Print class roster
            Console.WriteLine("\nClass roster:");
            double sum = 0.0;

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i] + " (" + grades[i] + ")");
                sum += grades[i];
            }

            double avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);
        }

        public static void ArrayEx()
        {
            // Allow for at most 30 students
            int maxStudents = 30;

            string[] students = new string[maxStudents];
            double[] grades = new double[maxStudents];

            string input;
            string newStudent;
            int numStudents = 0;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names
            do
            {
                input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    students[numStudents] = newStudent;
                    numStudents++;
                }

            } while (!Equals(newStudent, ""));

            // Get student grades
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine("Grade for " + students[i] + ": ");
                input = Console.ReadLine();
                double grade = double.Parse(input);
                grades[i] = grade;
            }

            // Print class roster
            Console.WriteLine("\nClass roster:");
            double sum = 0.0;

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine(students[i] + " (" + grades[i] + ")");
                sum += grades[i];
            }

            double avg = sum / numStudents;
            Console.WriteLine("Average grade: " + avg);
        }

        public static void DictionaryEx()
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("Student: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("Grade: ");
                    input = Console.ReadLine();
                    double newGrade = double.Parse(input);
                    students.Add(newStudent, newGrade);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");
            double sum = 0.0;

            foreach (KeyValuePair<string, double> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
                sum += student.Value;
            }

            double avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);
        }
    }
}
