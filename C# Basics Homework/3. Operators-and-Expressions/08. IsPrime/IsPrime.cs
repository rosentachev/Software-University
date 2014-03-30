using System;

class IsPrime
{
    static void Main()
    {
        //Write an expression that checks if given positive integer number n (n ≤ 100) 
        //is prime (i.e. it is divisible without remainder only to itself and 1).

        Console.Write("Enter a integer number <= 100: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        bool isPrime = true;

        if (number == 0 || number == 1 || number < 0)
        {
            isPrime = false;
            Console.WriteLine("isPrime? {0}", isPrime);
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine("isPrime? {0}", isPrime);
        }
    }
}
