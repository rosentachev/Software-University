using System;

class RectanglePerimeterAndArea
{
    static void Main()
    {
        //Write an expression that calculates rectangle’s perimeter and area by given width and height.

        Console.Write("Enter rectangle width: ");
        string input = Console.ReadLine();
        double rectWidth = double.Parse(input);
        Console.Write("Enter rectangle height: ");
        input = Console.ReadLine();
        double rectHeight = double.Parse(input);

        double rectPerimeter = (rectWidth + rectHeight) * 2;
        double rectArea = rectWidth * rectHeight;

        Console.WriteLine("The rectangle perimeter is {0} and the area is {1}", rectPerimeter, rectArea);
    }
}
