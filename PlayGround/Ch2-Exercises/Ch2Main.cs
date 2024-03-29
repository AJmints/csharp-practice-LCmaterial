﻿using PlayGround.Ch2_Exercises;
using PlayGround.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    internal class Ch2Main
    {
        public static void GetCh2() 
        {
            

            Console.WriteLine("Hello, World! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("We are going to calculate the area of a rectangle.\nWhat is the Width?");
            string widthString = Console.ReadLine();
            int width = int.Parse(widthString);
            Console.WriteLine("Great! Now what is the Height?");
            string heightString = Console.ReadLine();
            int height = int.Parse(heightString);

            Console.WriteLine("Alright, so the area is... " + CalculateArea.GetArea(width, height) + "\nWell done, now how many miles did you drive today?");
            string miles = Console.ReadLine();
            int milesDriven = int.Parse(miles);
            Console.WriteLine("Alright, how many gallons did you use?");
            string gallons = Console.ReadLine();
            int gallonsUsed = int.Parse(gallons);
            Console.WriteLine("Alright, so you got... " + GasCalc.GetMilage(milesDriven, gallonsUsed) + "mpg");

            Console.WriteLine("Awesome, next you will look at a string and enter a letter. If it is in the string, the console will print where the first instance of it is.\n\n");
            AliceAdventure.GetStringCount();

            Console.WriteLine("\nExcellent, returning to main menu.\n");
        }
    }
}
