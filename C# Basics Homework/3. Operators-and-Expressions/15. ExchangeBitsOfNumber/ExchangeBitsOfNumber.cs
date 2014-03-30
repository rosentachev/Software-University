using System;

class ExchangeBitsOfNumber
{
    static void Main()
    {
        //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

        Console.Write("Enter an unsigned integer: ");
        uint unInt = uint.Parse(Console.ReadLine());

        uint bitThree = (unInt & (1 << 3)) >> 3;
        uint bitFour = (unInt & (1 << 4)) >> 4;
        uint bitFive = (unInt & (1 << 5)) >> 5;
        uint bitTwentyFour = (unInt & (1 << 24)) >> 24;
        uint bitTwentyFive = (unInt & (1 << 25)) >> 25;
        uint bitTwentySix = (unInt & (1 << 26)) >> 26;
        uint temp;
        uint result;

        temp = ((bitThree == 0) ? (temp = unInt & ~((uint)(1 << 24))) : (temp = unInt | (1 << 24)));
        result = temp;
        temp = ((bitFour == 0) ? (temp = result & ~((uint)(1 << 25))) : (temp = result | (1 << 25)));
        result = temp;
        temp = ((bitFive == 0) ? (temp = result & ~((uint)(1 << 26))) : (temp = result | (1 << 26)));
        result = temp;
        temp = ((bitTwentyFour == 0) ? (temp = result & ~((uint)(1 << 3))) : (temp = result | (1 << 3)));
        result = temp;
        temp = ((bitTwentyFive == 0) ? (temp = result & ~((uint)(1 << 4))) : (temp = result | (1 << 4)));
        result = temp;
        temp = ((bitTwentySix == 0) ? (temp = result & ~((uint)(1 << 5))) : (temp = result | (1 << 5)));
        result = temp;

        Console.WriteLine("The binary representation of number {0} is:  {1}", unInt, Convert.ToString(unInt, 2).PadLeft(32, '0'));
        Console.WriteLine("Result number is: " + result);
        Console.WriteLine("The binary representaion of modified {0} is: {1}", unInt, Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
