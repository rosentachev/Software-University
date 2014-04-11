using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter value for n (smaller than 20): ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        if (number >= 1 && number <= 20)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int column = 0; column < number; column++)
                {
                    Console.Write(row + column + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Try again (1 <= n <= 20).");
        }
    }
}
