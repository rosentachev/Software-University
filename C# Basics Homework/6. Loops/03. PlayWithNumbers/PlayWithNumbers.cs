using System;

class PlayWithNumbers
{
    static void Main()
    {
        //Write a program that reads from the console a sequence of n integer numbers 
        //and returns the minimal, the maximal number, the sum and the average of all numbers 
        //(displayed with 2 digits after the decimal point). 
        //The input starts by the number n (alone in a line) followed by n lines, 
        //each holding an integer number.

        Console.Write("How many numbers you want to enter: ");
        string input = Console.ReadLine();
        int numbers = int.Parse(input);

        int n = 0;
        int minimal = int.MaxValue;
        int maximal = int.MinValue;
        double sum = 0;
        double avarage = 1;

        while (numbers > n)
        {
            // input
            int number = int.Parse(Console.ReadLine());

            // check minimal
            if (number < minimal)
            {
                minimal = number;
            }

            // check maximal
            if (number > maximal)
            {
                maximal = number;
            }

            // calculate sum
            sum += number;
            n++;
        }
        // calculate avarage
        avarage = sum / numbers;

        // output
        Console.WriteLine("min = " + minimal);
        Console.WriteLine("max = " + maximal);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("avg = {0:F2}", avarage);
    }
}
