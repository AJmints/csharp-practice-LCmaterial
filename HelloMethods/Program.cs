﻿using System;

namespace HelloMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("sp");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }

}