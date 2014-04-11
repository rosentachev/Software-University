using System;

class OddAndEvenProduct
{
    static void Main()
    {
        //You are given n integers (given in a single line, separated by a space). 
        //Write a program that checks whether the product of the odd elements is equal 
        //to the product of the even elements. Elements are counted from 1 to n, 
        //so the first element is odd, the second is even, etc.

        // input
        Console.Write("How many integers you want to enter: ");
        string input = Console.ReadLine();
        int n = int.Parse(input);
        Console.WriteLine("Enter {0} integers on a single line, separated by space.", n);
        input = Console.ReadLine();
        string[] numbers = new string[n];
        numbers = input.Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;

        // calculate products
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= int.Parse(numbers[i - 1]);
            }
            else
            {
                oddProduct *= int.Parse(numbers[i - 1]);
            }
        }

        // output
        Console.WriteLine("Is the odd numbers product is equal to even numbers product?");
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd product = {0}\n\reven product = {1}", oddProduct, evenProduct);
        }
    }
}
