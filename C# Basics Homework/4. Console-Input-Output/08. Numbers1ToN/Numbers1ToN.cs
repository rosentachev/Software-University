﻿using System;

class Numbers1ToN
{
    static void Main()
    {
        //Write a program that reads an integer number n from the console and 
        //prints all the numbers in the interval [1..n], each on a single line.

        Console.Write("n=");
        string input = Console.ReadLine();
        int n = int.Parse(input);

        Console.WriteLine("Numbers from 1 to n:");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
