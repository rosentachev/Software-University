using System;

class SumFiveNumbers
{
    static void Main()
    {
        //Write a program that enters 5 numbers (given in a single line, separated by a space), 
        //calculates and prints their sum.

        Console.WriteLine("Enter 5 numbers in a single line, separated by a space");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        double sum = 0.0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += double.Parse(numbers[i]);
        }
        Console.WriteLine("The sum is " + sum);
    }
}
