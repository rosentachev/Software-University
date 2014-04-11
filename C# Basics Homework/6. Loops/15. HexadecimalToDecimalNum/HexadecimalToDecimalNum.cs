using System;

class HexadecimalToDecimalNum
{
    static void Main()
    {
        //Using loops write a program that converts a hexadecimal integer number to its 
        //decimal form. The input is entered as string. The output should be a 
        //variable of type long. Do not use the built-in .NET functionality.

        Console.Write("Enter number in hexadecimal form: ");
        string hexNum = Console.ReadLine();
        long decimalNum = 0;
        int lastIndex = hexNum.Length - 1;
        int currentNumberInHex = 0;
        
        for (int i = 0; i < hexNum.Length; i++, lastIndex--)
        {
            switch (hexNum[i])
            {
                case 'A':
                    currentNumberInHex = 10;
                    break;
                case 'B':
                    currentNumberInHex = 11;
                    break;
                case 'C':
                    currentNumberInHex = 12;
                    break;
                case 'D':
                    currentNumberInHex = 13;
                    break;
                case 'E':
                    currentNumberInHex = 14;
                    break;
                case 'F':
                    currentNumberInHex = 15;
                    break;
                default:
                    currentNumberInHex = int.Parse(hexNum[i].ToString());
                    break;
            }

            long hexSum = 1;
            for (int j = 0; j < lastIndex; j++)
            {
                hexSum *= 16;
            }
            hexSum *= currentNumberInHex;
            decimalNum += hexSum;
        }
        Console.WriteLine("Number in decimal form: {0}", decimalNum);
    }
}
