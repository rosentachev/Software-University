using System;

class PrintASCIITable
{
    static void Main()
    {
        //write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255).

        for (int i = 0; i < 255; i++)
        {
            Console.WriteLine("(char){0} is: {1}", i, (char)i);
        }
    }
}
