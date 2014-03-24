using System;

class ExchangeVariables
{
    static void Main()
    {
        //Declare two integer variables a and b and assign them with 5 and 10 
        //and after that exchange their values. Print the variable values before and after the exchange.

        int firstVar = 5;
        int secondVar = 10;
        Console.WriteLine("Before exchange first variable is {0} and second variable is {1}.", firstVar, secondVar);
        int thirdVar = firstVar;
        firstVar = secondVar;
        secondVar = thirdVar;
        Console.WriteLine("After exchange first variable is {0} and second variable is {1}.", firstVar, secondVar);
    }
}
