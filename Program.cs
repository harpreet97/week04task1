using System;

namespace week04task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();

            Console.WriteLine("What is your firstname?");
            var firstname = Console.ReadLine();

            Console.WriteLine("What is your lastname?");
            var lastname = Console.ReadLine();

            Console.WriteLine("************************");

            Console.WriteLine(string.Format("My Full name is {0} {1}",firstname,lastname));
            
             Console.WriteLine("************************");

        
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
