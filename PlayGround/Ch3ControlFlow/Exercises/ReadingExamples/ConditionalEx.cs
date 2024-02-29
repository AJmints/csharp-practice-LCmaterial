using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Ch3ControlFlow.Exercises.ConditionalExamples
{
    internal class ConditionalEx
    {
        public static void ElseIfExample() 
        {
            Console.WriteLine("Enter a grade: ");
            string gradeString = Console.ReadLine();
            int grade = int.Parse(gradeString);
            if (grade < 60)
            {
                Console.WriteLine('F');
            }
            else if (grade < 70)
            {
                Console.WriteLine('D');
            }
            else if (grade < 80)
            {
                Console.WriteLine('C');
            }
            else if (grade < 90)
            {
                Console.WriteLine('B');
            }
            else
            {
                Console.WriteLine('A');
            }
        }

        public static void FallThroughWithSwitchExample()
        {
            Console.WriteLine("Enter an integer: ");
            string dayString = Console.ReadLine();
            int dayNum = int.Parse(dayString);

            string weekZone;
            switch (dayNum)
            {
                case 0:
                    weekZone = "Weekend";
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    weekZone = "Week Day";
                    break;
                case 6:
                    weekZone = "Weekend";
                    break;
                default:
                    // in this example, this block runs if none of the above blocks match
                    weekZone = "Int does not correspond to a day of the week";
                    break;
            }
            Console.WriteLine(weekZone);
        }
        
    }
}
