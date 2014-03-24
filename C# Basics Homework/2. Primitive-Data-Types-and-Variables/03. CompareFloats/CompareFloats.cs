using System;

class CompareFloats
{
    static void Main()
    {
        //Write a program that safely compares floating-point numbers with precision eps = 0.000001.

        float firstNumber = 5.3f;
        float secondNumber = 6.1f;
        bool firstCompare = Math.Abs(firstNumber - secondNumber) < 0.000001;
        Console.WriteLine("{0} is equal to {1} with precision of 0.000001 -> {2}", firstNumber, secondNumber, firstCompare);

        double thirdNumber = 5.00000001;
        double fourthNumber = 5.00000003;
        bool secondCompare = Math.Abs(thirdNumber - fourthNumber) < 0.000001;
        Console.WriteLine("{0} is equal to {1} with precision of 0.000001 -> {2}", thirdNumber, fourthNumber, secondCompare);

        double fifthNumber = -0.0000007;
        double sixthNumber = 0.00000007;
        bool thirdCompare = Math.Abs(fifthNumber - sixthNumber) < 0.000001;
        Console.WriteLine("{0} is equal to {1} with precision of 0.000001 -> {2}", fifthNumber, sixthNumber, thirdCompare);

        double seventhNumber = -4.999999;
        double eighthNumber = -4.999998;
        bool fourthCompare = Math.Abs(seventhNumber - eighthNumber) < 0.000001;
        Console.WriteLine("{0} is equal to {1} with precision of 0.000001 -> {2}", seventhNumber, eighthNumber, fourthCompare);
    }
}
