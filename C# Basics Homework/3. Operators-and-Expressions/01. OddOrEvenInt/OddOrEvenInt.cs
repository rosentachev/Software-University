using System;

class OddOrEvenInt
{
    static void Main()
    {
        //Write an expression that checks if given integer is odd or even.

        Console.Write("Please enter a integer number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        if (number % 2 == 0)
        {
            Console.WriteLine("Is odd? False");
        }
        else
        {
            Console.WriteLine("Is odd? True");
        }
    }
}
