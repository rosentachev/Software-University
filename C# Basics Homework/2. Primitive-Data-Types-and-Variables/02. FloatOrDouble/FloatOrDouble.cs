using System;

class FloatOrDouble
{
    static void Main()
    {
        //Which of the following values can be assigned to a variable of type float 
        //and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

        double firstNumber = 34.567839023;
        float secondNumber = 12.345f;
        double thirdNumber = 8923.1234857;
        float fourthNumber = 3456.091f;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}", firstNumber, secondNumber, thirdNumber, fourthNumber);
    }
}
