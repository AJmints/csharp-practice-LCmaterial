using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Ch3ControlFlow.Exercises.ReadingExamples
{
    internal class LoopsEx
    {
        public static void ForLoopEx()
        {
            Console.WriteLine("Enter a number to print the console counting it.");
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                int j = i + 1;
                Console.WriteLine(j);
            }

            Console.WriteLine("The following examples are For Each loops");
            Console.WriteLine("First example, we loop through an array of numbers.\n");
            int[] nums = { 1, 1, 2, 3, 5, 8, 13, 21 };

            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nThis example, we will loop thorugh the characters in a String\n");
            string msg = "Hello World";

            foreach (char c in msg.ToCharArray())
            {
                Console.WriteLine(c);
            }
        }

        public static void WhileAndDoWhileLoopEx()
        {
            Console.WriteLine("While Loop example.");
            int w = 0;
            while (w < 3)
            {
                w++;
            }

            Console.WriteLine("Do While loop example.");
            bool exit = true;
            do
            {
                Console.WriteLine("Enter 1 to break the do while loop.\n");
                string input = Console.ReadLine();
                if (input.Equals("1"))
                {
                    exit = false;
                }
            } while (exit);
            Console.WriteLine("\n");
        }

        public static void ContinueEx()
        {
            int[] someOtherInts = { 1, 10, 2, 3, 5, 8, 10 };
            int newSearchTerm = 10;
            foreach (int oneNewInt in someOtherInts)
            {
                if (oneNewInt == newSearchTerm)
                {
                    Console.WriteLine("Found it!");
                    continue;
                }
                Console.WriteLine("Not here");
            }
        }
    }
}
