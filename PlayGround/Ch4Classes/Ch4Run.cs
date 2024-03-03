using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Ch4Classes
{
    internal class Ch4Run
    {
        public static void ReadingEx()
        {
            
            Console.WriteLine("Select an example to view.\n1. Create a Class example\nPress another key to return to main menu.");
            string input = Console.ReadLine();

            if (input.Equals("1"))
            {
                Student student = new Student("Miles", 12, 12, 90.8);
                Console.WriteLine(student.StudentInfo() + "\n");
            }
            else
            {
                Console.WriteLine("\nReturning to main menu...\n");
            }
        }
    }
}
