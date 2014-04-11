using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        //Write a program that, depending on the user’s choice, inputs an 
        //int, double or string variable. If the variable is int or double, 
        //the program increases it by one. If the variable is a string, 
        //the program appends "*" at the end. Print the result at the console. Use switch statement.

        Console.WriteLine("Please choose a type:\r\n1 --> int\r\n2 --> double\r\n3 --> string");
        string input = Console.ReadLine();
        int choice = int.Parse(input);

        switch (choice)
        {
            case 1:
                Console.Write("You chooce Int variable. Enter a Int number: ");
                input = Console.ReadLine();
                int integerNumber = int.Parse(input);
                Console.WriteLine("The result is --> {0}", integerNumber + 1);
                break;
            case 2:
                Console.Write("You chooce Double variable. Enter a Double number: ");
                input = Console.ReadLine();
                double doubleNumber = double.Parse(input);
                Console.WriteLine("The result is --> {0}", doubleNumber + 1);
                break;
            case 3:
                Console.Write("You chooce String variable. Enter a String: ");
                input = Console.ReadLine();
                Console.WriteLine("The result is --> {0}", input + "*");
                break;
            default:
                Console.WriteLine("You must enter 1, 2 or 3 as an input!");
                break;
        }
    }
}
