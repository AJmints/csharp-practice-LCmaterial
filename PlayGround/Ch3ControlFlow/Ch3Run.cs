using PlayGround.Ch3ControlFlow.Exercises.ConditionalExamples;
using PlayGround.Ch3ControlFlow.Exercises.ReadingExamples;
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
            Console.WriteLine("Select an example to view.\n1. Else If Example\n2. Fall Through Example\n3. For Loop and For Each Example\n4. While and Do While Loop Examples\n5. List Collections Example\n6. Array Collections Example\n7. Dictionary Collections Example\nPress another key to return to main menu.");
            string input = Console.ReadLine();

            if (input.Equals("1"))
            {
                ConditionalEx.ElseIfExample();
            }
            else if (input.Equals("2"))
            {
                ConditionalEx.FallThroughWithSwitchExample();
            } 
            else if (input.Equals("3"))
            {
                LoopsEx.ForLoopEx();
            }
            else if (input.Equals("4"))
            {
                LoopsEx.WhileAndDoWhileLoopEx();
            }
            else if (input.Equals("5"))
            {
                CollectionsEx.ListExamples();
            }
            else if (input.Equals("6"))
            {
                CollectionsEx.ArrayEx();
            }
            else if (input.Equals("7"))
            {
                CollectionsEx.DictionaryEx();
            }
            else 
            {
                Console.WriteLine("\nReturning to the main menu...\n");
            }
            

        }
    }
}
