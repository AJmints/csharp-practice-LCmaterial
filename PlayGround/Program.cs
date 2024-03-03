using PlayGround;
using PlayGround.Ch3ControlFlow;
using PlayGround.Ch4Classes;
using PlayGround.Classes;

public class Program
{
    public static void Main(string[] args)
    {
        
        bool continueLoop = true;

        do
        {
            Console.WriteLine("Select the console app you want to run.\n1. Basic Data Types\n2. Control Flow and Collections Reading Examples\nEnter 0 to exit the app.\n");
            string input = Console.ReadLine();
            if (input.Equals("1"))
            {
                Ch2Main.GetCh2();
            } 
            else if (input.Equals("2"))
            {
                Ch3Run.ReadingEx();
            }
            else if (input.Equals("3"))
            {
                Ch4Run.ReadingEx();
            }
            else if (input.Equals("0"))
            {
                continueLoop = false;
            }
        } while (continueLoop);
        
        
        
    }
}

