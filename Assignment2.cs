using System;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;

            // Ask the user to enter a real number
            Console.Write("Enter a real number: ");
            x = double.Parse(Console.ReadLine());

            // Check membership of x in the set I
            if ((x >= 2 && x < 3) || (x >= 0 && x <= 1) || (x >= -10 && x <= -2))
            {
                Console.WriteLine("x belongs to I");
            }
            else
            {
                Console.WriteLine("x does not belong to I");
            }

            // Add a statement to wait for user input before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
