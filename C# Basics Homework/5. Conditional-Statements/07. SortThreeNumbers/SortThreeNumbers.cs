using System;

class SortThreeNumbers
{
    static void Main()
    {
        //Write a program that enters 3 real numbers and prints them sorted 
        //in descending order. Use nested if statements. 
        //Don’t use arrays and the built-in sorting functionality.

        Console.WriteLine("Enter 3 real numbers (on separate lines)");
        string input = Console.ReadLine();
        double a = double.Parse(input);
        input = Console.ReadLine();
        double b = double.Parse(input);
        input = Console.ReadLine();
        double c = double.Parse(input);

        if (a > b && a > c)
        {
            if (b > c)
            {
                Console.WriteLine("result --> {0} {1} {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("result --> {0} {1} {2}", a, c, b);
            }
        }
        if (b > a && b > c)
        {
            if (a > c)
            {
                Console.WriteLine("result --> {0} {1} {2}", b, a, c);
            }
            else
            {
                Console.WriteLine("result --> {0} {1} {2}", b, c, a);
            }
        }
        if (c > a && c > b)
        {
            if (a > b)
            {
                Console.WriteLine("result --> {0} {1} {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("result --> {0} {1} {2}", c, b, a);
            }
        }
    }
}
