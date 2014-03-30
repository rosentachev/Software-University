using System;

class FourDigitNumber
{
    static void Main()
    {
        //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and play with it.

        Console.Write("Enter a four-digit number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        //take first digit
        int firstDigit = number / 1000;
        firstDigit %= 10;
        //take second digit
        int secondDigit = number / 100;
        secondDigit %= 10;
        //take third digit
        int thirdDigit = number / 10;
        thirdDigit %= 10;
        //take fourth digit
        int fourthDigit = number % 10;

        Console.WriteLine("The sum of the digits is: {0}", firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.WriteLine("The number in reversed order of digits: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("Last digin in first position: {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine("Exchange second and third digit: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
    }
}
