using System;

class DecimalToBinaryNum
{
    static void Main()
    {
        //Using loops write a program that converts an integer number to its 
        //binary representation. The input is entered as long. The output should be 
        //a variable of type string. Do not use the built-in .NET functionality.

        Console.Write("Enter number in decimal form: ");
        string input = Console.ReadLine();
        long decimalNum = long.Parse(input);
        string binaryNum = "";
        int remainder = 1;

        while (decimalNum > 0)
        {
            remainder = (int)decimalNum % 2;
            decimalNum /= 2;
            binaryNum = remainder + binaryNum;
        }
        Console.WriteLine("Number in binary form: {0}", binaryNum);
    }
}
