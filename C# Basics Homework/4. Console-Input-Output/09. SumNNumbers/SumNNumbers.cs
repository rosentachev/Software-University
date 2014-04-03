using System;

class SumNNumbers
{
    static void Main()
    {
        //Write a program that enters a number n and after that 
        //enters more n numbers and calculates and prints their sum.

        Console.Write("How many numbers you want to sum: ");
        string input = Console.ReadLine();
        int n = int.Parse(input);
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            input = Console.ReadLine();
            sum += double.Parse(input);
        }
        Console.WriteLine("The sum of all numbers is equal to {0}", sum);
    }
}
