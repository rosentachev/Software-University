using System;

class DivideBy7and5
{
    static void Main()
    {
        //Write a Boolean expression that checks for given integer if it 
        //can be divided (without remainder) by 7 and 5 in the same time.

        Console.Write("Please enter a integer number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        bool division = number % 7 == 0 && number % 5 == 0 && number != 0;
        Console.WriteLine("The number can be divided by 7 and 5 at the same time: {0}", division);
    }
}
