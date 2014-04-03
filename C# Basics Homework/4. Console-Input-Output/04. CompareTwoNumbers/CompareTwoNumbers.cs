using System;

class CompareTwoNumbers
{
    static void Main()
    {
        //Write a program that gets two numbers from the console and prints 
        //the greater of them. Try to implement this without if statements.

        Console.Write("Enter first number: ");
        string input = Console.ReadLine();
        double firstNumber = double.Parse(input);
        Console.Write("Enter second number: ");
        input = Console.ReadLine();
        double secondNumber = double.Parse(input);

        Console.WriteLine(firstNumber > secondNumber ? "The greater number is {0}" : "The greater number is {1}",
                            firstNumber, secondNumber);
    }
}
