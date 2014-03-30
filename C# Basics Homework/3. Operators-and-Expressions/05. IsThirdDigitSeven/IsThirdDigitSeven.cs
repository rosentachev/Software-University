using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        //Write an expression that checks for given integer if its third digit from right-to-left is 7.

        Console.Write("Please enter a integer number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        int divideBy100 = number / 100;
        Console.WriteLine("The third digid of the number is seven? {0}", divideBy100 % 10 == 7 && divideBy100 != 0);
    }
}
