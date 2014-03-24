using System;

class CopyrightSymbolTriangle
{
    static void Main()
    {
        //Write a program that prints an isosceles triangle of 9 copyright symbols ©.

        char copyrightSymbol = '\u00A9';
        Console.WriteLine(@"
                            {0}
                           {0} {0}
                          {0}   {0}
                         {0} {0} {0} {0}", copyrightSymbol);
    }
}
