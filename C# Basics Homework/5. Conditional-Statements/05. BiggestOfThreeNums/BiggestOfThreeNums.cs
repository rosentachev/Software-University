using System;

class BiggestOfThreeNums
{
    static void Main()
    {
        //Write a program that finds the biggest of three numbers.

        Console.WriteLine("Enter three numbers (on separate lines)");
        string input = Console.ReadLine();
        double a = double.Parse(input);
        input = Console.ReadLine();
        double b = double.Parse(input);
        input = Console.ReadLine();
        double c = double.Parse(input);

        if (a > b && a > c)
        {
            Console.WriteLine("The biggest number is {0}", a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("The biggest number is {0}", b);
        }
        else
        {
            Console.WriteLine("The biggest number is {0}", c);
        }
    }
}
