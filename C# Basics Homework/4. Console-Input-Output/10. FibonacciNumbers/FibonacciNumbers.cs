using System;

class FibonacciNumbers
{
    static void Main()
    {
        //Write a program that reads a number n and prints on the console the first n members 
        //of the Fibonacci sequence (at a single line, separated by spaces) : 
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...

        Console.Write("How many numbers of Fibonacci you want to print: ");
        string input = Console.ReadLine();
        int n = int.Parse(input);
        decimal firstMumber = 0;
        decimal secondMember = 1;
        decimal sum = firstMumber + secondMember;

        Console.Write("{0}, {1}", firstMumber, secondMember);
        for (int i = 2; i < n; i++)
        {
            sum = firstMumber + secondMember;
            firstMumber = secondMember;
            secondMember = sum;
            Console.Write(", " + sum);
        }
        Console.WriteLine();
    }
}
