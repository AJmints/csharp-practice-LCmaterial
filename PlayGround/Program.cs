using PlayGround;
using PlayGround.Ch3ControlFlow;
using PlayGround.Classes;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Select the console app you want to run.\n1. Basic Data Types\n2. Control Flow and Collections");
        string input = Console.ReadLine();


        if (input.Equals("1"))
        {
            Ch2Main.GetCh2();
        } 
        else if (input.Equals("2"))
        {
            Ch3Run.ReadingEx();
        }
        
        
    }
}

