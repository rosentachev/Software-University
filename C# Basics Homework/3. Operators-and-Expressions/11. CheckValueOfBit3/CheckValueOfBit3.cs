using System;

class CheckValueOfBit3
{
    static void Main()
    {
        //Using bitwise operators, write an expression for finding the value of the bit #3 
        //of a given unsigned integer. The bits are counted from right to left, starting from bit #0. 
        //The result of the expression should be either 1 or 0.

        Console.Write("Enter an unsigned integer number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        int bitPosition = 3;

        Console.WriteLine("Number in binary -> " + Convert.ToString(number, 2).PadLeft(16, '0'));
        int numRightBitPos = number >> bitPosition;
        int bitValue = numRightBitPos & 1;
        Console.WriteLine("The value of bit at position 3 of number {0} is {1}", number, bitValue);
    }
}
