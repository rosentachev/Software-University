using System;

class DecimalToHexadecimalNum
{
    static void Main()
    {
        //Using loops write a program that converts an integer number to its 
        //hexadecimal representation. The input is entered as long. The output should be 
        //a variable of type string. Do not use the built-in .NET functionality.

        Console.Write("Enter number in decimal form: ");
        string input = Console.ReadLine();
        long decimalNum = long.Parse(input);
        string hexNum = "";
        long remainder = 1;

        if (decimalNum == 0)
        {
            hexNum = "0";
        }
        else
        {
            while (decimalNum > 0)
            {
                remainder = decimalNum % 16;
                decimalNum /= 16;
                switch (remainder)
                {
                    case 10:
                        hexNum = "A" + hexNum;
                        break;
                    case 11:
                        hexNum = "B" + hexNum;
                        break;
                    case 12:
                        hexNum = "C" + hexNum;
                        break;
                    case 13:
                        hexNum = "D" + hexNum;
                        break;
                    case 14:
                        hexNum = "E" + hexNum;
                        break;
                    case 15:
                        hexNum = "F" + hexNum;
                        break;
                    default:
                        hexNum = remainder + hexNum;
                        break;
                }
            }
        }
        Console.WriteLine("Number in hexadecimal form: {0}", hexNum);
    }
}
