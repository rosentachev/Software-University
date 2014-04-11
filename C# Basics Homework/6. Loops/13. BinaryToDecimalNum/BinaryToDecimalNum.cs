using System;

class BinaryToDecimalNum
{
    static void Main()
    {
        //Using loops write a program that converts a binary integer number to its 
        //decimal form. The input is entered as string. The output should be 
        //a variable of type long. Do not use the built-in .NET functionality.

        Console.Write("Enter number in binary form: ");
        string binaryNum = Console.ReadLine();
        long decimalNum = 0;

        for (int i = 0; i < binaryNum.Length; i++)
        {
            if (binaryNum[binaryNum.Length - i - 1] == '1')
            {
                decimalNum += (int)Math.Pow(2, i);
            }
        }
        Console.WriteLine("Number in decimal form: {0}", decimalNum);
    }
}
