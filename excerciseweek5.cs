using System;

class NumberClassifier
{
    static void Main()
    {
        
        Console.Write("Enter a whole number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is positive and even");
            }
            else
            {
                Console.WriteLine("The number is positive and odd");
            }
        }
        else if (number < 0)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is negative and even");
            }
            else
            {
                Console.WriteLine("The number is negative and odd");
            }
        }
        else
        {
            Console.WriteLine("The number is zero (and it is even)");
        }
    }
}








