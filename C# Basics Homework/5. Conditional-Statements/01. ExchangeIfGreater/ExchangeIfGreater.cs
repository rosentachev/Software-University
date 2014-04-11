using System;

class ExchangeIfGreater
{
    static void Main()
    {
        //Write an if-statement that takes two integer variables a and b and 
        //exchanges their values if the first one is greater than the second one. 
        //As a result print the values a and b, separated by a space.

        Console.WriteLine("Enter two integer numbers");
        string input = Console.ReadLine();
        double a = double.Parse(input);
        input = Console.ReadLine();
        double b = double.Parse(input);

        double exchange = b;

        if (a > b)
        {
            b = a;
            a = exchange;
            Console.WriteLine("result --> {0} {1}", a, b);
        }
        else
        {
            Console.WriteLine("result --> {0} {1}", a, b);
        }
    }
}
