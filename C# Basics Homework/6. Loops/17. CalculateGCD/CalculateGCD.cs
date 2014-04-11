using System;

class CalculateGCD
{
    static void Main()
    {
        //Write a program that calculates the greatest common divisor (GCD) 
        //of given two integers a and b. Use the Euclidean algorithm (find it in Internet).

        Console.Write("Enter first number a = ");
        string input = Console.ReadLine();
        int firstNumber = int.Parse(input);
        Console.Write("Enter second number b = ");
        input = Console.ReadLine();
        int secondNumber = int.Parse(input);

        while (firstNumber != 0 && secondNumber != 0)
        {
            if (firstNumber > secondNumber)
            {
                firstNumber %= secondNumber;
            }
            else
            {
                secondNumber %= firstNumber;
            }
        }
        Console.WriteLine("For your input GCD = {0}", Math.Max(firstNumber, secondNumber));
        //if (firstNumber == 0)
        //{
        //    Console.WriteLine("For your input GCD = {0}", secondNumber);
        //}
        //else
        //{
        //    Console.WriteLine("For your input GCD = {0}", firstNumber);
        //}
    }
}
