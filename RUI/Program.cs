using System;

namespace RUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)

        
            {
                //clean the screen on the terminal
                Console.Clear();
                Console.WriteLine("Hello World!");
                string uderChoice;
                Console.WriteLine("[1] - Do you want to clear the screen?")
                Console.WriteLine("[2] - Do you want to excit out of the program?");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("User has chosen to clear the screen");
                        Console.WriteLine("Press Enter to constinue...");
                        Console.ReadLine();
                        break;
                    case "2":
                        repeat = false;
                        Console.WriteLine("You have exited to the program!");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();

                    default:
                        Console.WriteLine("What the heck did you just type, try again");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;
                }
            }    
       }
    }
}
