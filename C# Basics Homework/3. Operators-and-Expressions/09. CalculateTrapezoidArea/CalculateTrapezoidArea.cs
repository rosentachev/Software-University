using System;

class CalculateTrapezoidArea
{
    static void Main()
    {
        //Write an expression that calculates trapezoid's area by given sides a and b and height h.

        Console.Write("Trapezoid side a=");
        string input = Console.ReadLine();
        double a = double.Parse(input);
        Console.Write("Trapezoid side b=");
        input = Console.ReadLine();
        double b = double.Parse(input);
        Console.Write("Trapezoid height h=");
        input = Console.ReadLine();
        double h = double.Parse(input);

        double area = ((a + b) / 2) * h;
        Console.WriteLine("Trapezoid's area={0}", area);
    }
}
