using System;

class CalculateFormula
{
    static void Main()
    {
        //Write a program that, for a given two integer numbers n and x, 
        //calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. 
        //Print the result with 5 digits after the decimal point.

        Console.Write("Enter int n = ");
        string input = Console.ReadLine();
        int n = int.Parse(input);
        Console.Write("Enter int x = ");
        input = Console.ReadLine();
        int x = int.Parse(input);

        double factorial = 1.00;
        double power = 1.00;
        double sum = 1.00;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power = Math.Pow(x, i);
            sum += factorial / power;
        }
        Console.WriteLine("sum = {0:F5}", sum);
    }
}
