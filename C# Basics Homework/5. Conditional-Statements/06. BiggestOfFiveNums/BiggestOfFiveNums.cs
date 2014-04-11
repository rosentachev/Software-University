using System;

class BiggestOfFiveNums
{
    static void Main()
    {
        //Write a program that finds the biggest of five numbers by using only five if statements.

        Console.WriteLine("Enter five numbers (on separate lines)");
        string input = Console.ReadLine();
        double a = double.Parse(input);
        input = Console.ReadLine();
        double b = double.Parse(input);
        input = Console.ReadLine();
        double c = double.Parse(input);
        input = Console.ReadLine();
        double d = double.Parse(input);
        input = Console.ReadLine();
        double e = double.Parse(input);

        double biggestNumber = a;

        if (b > biggestNumber)
        {
            biggestNumber = b;
        }
        if (c > biggestNumber)
        {
            biggestNumber = c;
        }
        if (d > biggestNumber)
        {
            biggestNumber = d;
        }
        if (e > biggestNumber)
        {
            biggestNumber = e;
        }
        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}
