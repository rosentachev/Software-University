using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        //Write a program that enters from the console a positive integer n 
        //and prints all the numbers from 1 to n, on a single line, separated by a space.

        Console.Write("Enter a positive int number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        int startNumber = 1;

        while (number >= startNumber)
        {
            Console.Write(startNumber + " ");
            startNumber++;
        }
    }
}
