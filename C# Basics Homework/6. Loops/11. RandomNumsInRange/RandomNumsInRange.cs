using System;

class RandomNumsInRange
{
    static void Main()
    {
        //Write a program that enters 3 integers n, min and max (min <= max) 
        //and prints n random numbers in the range [min...max].

        Console.Write("n = ");
        string input = Console.ReadLine();
        int numbers = int.Parse(input);
        Console.Write("Range min value = ");
        input = Console.ReadLine();
        int minValue = int.Parse(input);
        Console.Write("Range max value = ");
        input = Console.ReadLine();
        int maxValue = int.Parse(input);

        if (minValue <= maxValue)
        {
            Random randomNumbers = new Random();
            for (int i = 0; i < numbers; i++)
            {
                Console.Write("{0} ", randomNumbers.Next(minValue, maxValue + 1));
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input! (min value <= max value)");
        }
    }
}
