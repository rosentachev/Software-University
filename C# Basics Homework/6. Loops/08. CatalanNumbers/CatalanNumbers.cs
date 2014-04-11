using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Please enter Nth Catalan number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        BigInteger factorial2N = 1;
        BigInteger nPlusOneFactorial = 1;
        BigInteger nFactorial = 1;

        // find (2*number) factorial
        for (int i = 1; i <= 2 * number; i++)
        {
            factorial2N *= i;
        }
        Console.WriteLine("(2*n)! = {0}", factorial2N);

        // find (n + 1) factorial
        for (int i = 1; i <= number + 1; i++)
        {
            nPlusOneFactorial *= i;
        }
        Console.WriteLine("(n+1)! = {0}", nPlusOneFactorial);

        // find n factorial
        for (int i = 1; i <= number; i++)
        {
            nFactorial *= i;
        }
        Console.WriteLine("n! = {0}", nFactorial);

        // result
        Console.WriteLine("Calculation for Nth Catalan number is equal to: {0}", factorial2N / (nPlusOneFactorial * nFactorial));
    }
}
