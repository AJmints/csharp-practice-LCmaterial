using PlayGround.Ch3ControlFlow.Exercises.ConditionalExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Ch3ControlFlow
{
    internal class Ch3Run
    {
        public static void ReadingEx()
        {
            Console.WriteLine("Select an example to view.\n1. Else If Example\n2. Fall Through Example");
            string input = Console.ReadLine();

            if (input.Equals("1"))
            {
                ConditionalEx.ElseIfExample();
            }
            else if (input.Equals("2"))
            {
                ConditionalEx.FallThroughWithSwitchExample();
            } 
            else
            {
                Console.WriteLine("You did not select an option. Returning...\n");
            }
            

        }
    }
}
