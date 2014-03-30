using System;

class ExtractBitFromInt
{
    static void Main()
    {
        //Write an expression that extracts from given integer n the value of given bit at index p.

        Console.Write("Enter a integer number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        Console.Write("Value of which bit you want to get: ");
        input = Console.ReadLine();
        int bitPosition = int.Parse(input);

        Console.WriteLine("Binary number -> " + Convert.ToString(number, 2).PadLeft(16, '0'));
        int numRightBitPos = number >> bitPosition;
        int bitValue = numRightBitPos & 1;
        Console.WriteLine("The value of bit at position {0} of number {1} is {2}", bitPosition, number, bitValue);
    }
}
