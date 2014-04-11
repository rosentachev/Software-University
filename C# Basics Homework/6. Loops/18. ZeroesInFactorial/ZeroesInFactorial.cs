using System;
using System.Numerics;

class ZeroesInFactorial
{
    static void Main()
    {
        //Write a program that calculates with how many zeroes the factorial 
        //of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000.

        Console.Write("Enter a number for factorial: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        BigInteger numberFactorial = 1;
        int countZeros = 0;

        for (int i = 1; i <= number; i++)
        {
            numberFactorial *= i;
        }
        Console.WriteLine("n! = {0}", numberFactorial);

        for (int j = 5; number / j >= 1; j *= 5)
        {
            countZeros += number / j;
        }
        Console.WriteLine("Trailing zeros = {0}", countZeros);
    }
}
