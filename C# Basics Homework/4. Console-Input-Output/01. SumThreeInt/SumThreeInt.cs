using System;

class SumThreeInt
{
    static void Main()
    {
        //Write a program that reads 3 integer numbers from the console and prints their sum.

        Console.Write("Enter first number: ");
        string input = Console.ReadLine();
        int firstNum = int.Parse(input);
        Console.Write("Enter second number: ");
        input = Console.ReadLine();
        int secondNum = int.Parse(input);
        Console.Write("Enter third number: ");
        input = Console.ReadLine();
        int thirdNum = int.Parse(input);

        Console.WriteLine("The sum of the nnumber is {0}", firstNum + secondNum + thirdNum);
    }
}
