using System;

class MultiplicationSign
{
    static void Main()
    {
        //Write a program that shows the sign (+, - or 0) of the product of 
        //three real numbers, without calculating it. Use a sequence of if operators.

        Console.WriteLine("Enter 3 real numbers (on separate lines)");
        string input = Console.ReadLine();
        double a = double.Parse(input);
        input = Console.ReadLine();
        double b = double.Parse(input);
        input = Console.ReadLine();
        double c = double.Parse(input);

        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: +");
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: +");
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: +");
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: +");
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: -");
        }
        else if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: -");
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: -");
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: -");
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The result is zero because one of the numbers is zero.");
        }
    }
}
