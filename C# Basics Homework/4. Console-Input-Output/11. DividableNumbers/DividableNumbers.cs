using System;

class DividableNumbers
{
    static void Main()
    {
        //Write a program that reads two positive integer numbers and prints 
        //how many numbers p exist between them such that the reminder of the division by 5 is 0.

        Console.Write("Enter a positive int number: ");
        string input = Console.ReadLine();
        int start = int.Parse(input);
        Console.Write("Enter another positive int number > first one: ");
        input = Console.ReadLine();
        int end = int.Parse(input);
        int p = 0;

        //check if the second number is greater than the first
        while (start > end)
        {
            Console.WriteLine("Second number must be greater than first! Try again.");
            Console.Write("Enter a positive int number: ");
            input = Console.ReadLine();
            start = int.Parse(input);
            Console.Write("Enter another positive int number > first one: ");
            input = Console.ReadLine();
            end = int.Parse(input);
        }

        //check and print the numbers in the diapason
        Console.WriteLine("The diapason is [{0}...{1}]", start, end);
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("Number % 5 == 0 -> {0}", i);
                p++;
            }
        }
        Console.WriteLine("There are {0} numbers in the diapason divisible by 5 without reminder.", p);
    }
}
