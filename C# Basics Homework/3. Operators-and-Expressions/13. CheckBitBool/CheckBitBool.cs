using System;

class CheckBitBool
{
    static void Main()
    {
        //Write a Boolean expression that returns if the bit at position p 
        //(counting from 0, starting from the right) in given integer number n has value of 1.

        Console.Write("Enter a integer number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        Console.Write("Value of which bit you want to get: ");
        input = Console.ReadLine();
        int bitPosition = int.Parse(input);

        Console.WriteLine("Binary number -> " + Convert.ToString(number, 2).PadLeft(16, '0'));
        int numRightBitPos = number >> bitPosition;
        int bitValue = numRightBitPos & 1;
        bool isOne = bitValue == 1;
        Console.WriteLine("bit @ position {0} == 1 -> {1}", bitPosition, isOne);
    }
}
