using System;

class ModifyBitAtPosition
{
    static void Main()
    {
        //We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
        //Write a sequence of operators (a few lines of C# code) that modifies n to 
        //hold the value v at the position p from the binary representation of n while preserving all other bits in n.

        Console.Write("Enter a integer number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        Console.Write("Enter a bit value (0 or 1): ");
        input = Console.ReadLine();
        int bitValue = int.Parse(input);
        Console.Write("Which bit you want to modify: ");
        input = Console.ReadLine();
        int bitPosition = int.Parse(input);

        Console.WriteLine("Binary number -> " + Convert.ToString(number, 2).PadLeft(16, '0'));

        if (bitValue == 1)
        {
            int setOne = 1 << bitPosition;
            int foundBitOne = number | setOne;
            Console.WriteLine("Result number -> " + foundBitOne);
            Console.WriteLine("Binary result -> " + Convert.ToString(foundBitOne, 2).PadLeft(16, '0'));
        }
        else
        {
            int setZero = ~(1 << bitPosition);
            int foundBitZero = number & setZero;
            Console.WriteLine("Result number -> " + foundBitZero);
            Console.WriteLine("Binary result -> " + Convert.ToString(foundBitZero, 2).PadLeft(16, '0'));
        }
    }
}
