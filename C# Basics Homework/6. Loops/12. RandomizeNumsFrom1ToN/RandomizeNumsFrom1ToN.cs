using System;

class RandomizeNumsFrom1ToN
{
    static void Main()
    {
        //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

        Console.Write("n = ");
        string input = Console.ReadLine();
        int n = int.Parse(input);
        bool[] printedNumber = new bool[n + 1];

        Random randomNum = new Random();

        for (int i = 0; i < n; i++)
        {
            int numberToPrint = randomNum.Next(1, n + 1);
            if (!printedNumber[numberToPrint])
            {
                Console.Write(numberToPrint + " ");
                printedNumber[numberToPrint] = true;
            }
            else
            {
                i--;
            }
        }
        Console.WriteLine();
    }
}
