using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        //Write a program that reads the radius r of a circle and prints its 
        //perimeter and area formatted with 2 digits after the decimal point.

        Console.Write("Enter cirle radius r=");
        string input = Console.ReadLine();
        double radius = double.Parse(input);

        //calculate circle perimeter
        double circlePerimeter = 2 * Math.PI * radius;
        //calculate circle area
        double circleArea = Math.PI * (radius * radius);
        //print
        Console.WriteLine("The circle with radius {0} have perimeter {1:0.00} and area {2:0.00}", radius, circlePerimeter, circleArea);
    }
}
