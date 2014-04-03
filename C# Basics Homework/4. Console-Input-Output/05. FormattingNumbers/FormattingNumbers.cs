using System;

class FormattingNumbers
{
    static void Main()
    {
        //Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), 
        //a floating-point b and a floating-point c and prints them in 4 virtual 
        //columns on the console. Each column should have a width of 10 characters. 
        //The number a should be printed in hexadecimal, left aligned; then the 
        //number a should be printed in binary form, padded with zeroes, then the 
        //number b should be printed with 2 digits after the decimal point, right aligned; 
        //the number c should be printed with 3 digits after the decimal point, left aligned.

        Console.Write("Enter integer number a (0 <= a <= 500): ");
        string input = Console.ReadLine();
        int a = int.Parse(input);
        while (a < 0 || a > 500)
        {
            Console.WriteLine("Invalid input! Try again.");
            input = Console.ReadLine();
            a = int.Parse(input);
        }
        Console.Write("Enter a floating-point number b: ");
        input = Console.ReadLine();
        float b = float.Parse(input);
        Console.Write("Enter a floating-point number c: ");
        input = Console.ReadLine();
        float c = float.Parse(input);

        Console.Write("|{0,-10:X}|", a);
        Console.Write("|{0}|", Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write("|{0,10:F2}|", b);
        Console.WriteLine("|{0,-10:F3}|", c);
    }
}
