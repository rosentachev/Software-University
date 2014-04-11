using System;
using System.Numerics;

class FactorialsFormula
{
    static void Main()
    {
        //Your task is to write a program that calculates n! / (k! * (n-k)!) 
        //for given n and k (1 < k < n < 100). Try to use only two loops.

        Console.Write("Enter number for n!: ");
        string input = Console.ReadLine();
        int n = int.Parse(input);
        Console.Write("Enter number for k!: ");
        input = Console.ReadLine();
        int k = int.Parse(input);

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        int nMinusK = n - k;
        BigInteger nMinusKFact = 1;

        if (1 < k && k < n && n < 100)
        {
            // find n factorial
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }
            Console.WriteLine("n! = {0}", nFactorial);

            // find k factorial
            for (int i = 1; i <= k; i++)
            {
                kFactorial *= i;
            }
            Console.WriteLine("k! = {0}", kFactorial);

            // find (n-k) factorial
            for (int i = 1; i <= nMinusK; i++)
            {
                nMinusKFact *= i;
            }
            Console.WriteLine("(n-k)! = {0}", nMinusKFact);

            // result
            Console.WriteLine("n! / (k! * (n-k)! = {0}", nFactorial / (kFactorial * nMinusKFact));
        }
        else
        {
            Console.WriteLine("Invalid input! (1 < k < n < 100)");
        }
    }
}
