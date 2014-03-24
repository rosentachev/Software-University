using System;

class PlayWithNullValue
{
    static void Main()
    {
        //Create a program that assigns null values to an integer and to a double variable. 
        //Try to print these variables at the console. Try to add some number or 
        //the null literal to these variables and print the result.

        int? nullInteger = null;
        double? nullDouble = null;

        Console.WriteLine("Null integer -> {0}", nullInteger);
        Console.WriteLine("Null integer + 5 -> {0}", nullInteger + 5);
        Console.WriteLine("Null integer null literal -> {0}", nullInteger + null);

        Console.WriteLine("Null double -> {0}", nullDouble);
        Console.WriteLine("Null double + 5.5 -> {0}", nullDouble + 5.5);
        Console.WriteLine("Null double + null literal -> {0}", nullDouble + null);
    }
}
