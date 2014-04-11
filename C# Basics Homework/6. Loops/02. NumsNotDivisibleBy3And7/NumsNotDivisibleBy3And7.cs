using System;

class NumsNotDivisibleBy3And7
{
    static void Main()
    {
        //Write a program that enters from the console a positive integer n 
        //and prints all the numbers from 1 to n not divisible by 3 and 7, 
        //on a single line, separated by a space.

        Console.Write("Enter a positive int number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        int startNumber = 1;

        while (number >= startNumber)
        {
            if (startNumber % 3 != 0 && startNumber % 7 != 0)
            {
                Console.Write(startNumber + " ");
            }
            startNumber++;
        }
    }
}
