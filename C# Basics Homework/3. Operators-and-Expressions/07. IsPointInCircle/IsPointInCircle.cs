using System;

class IsPointInCircle
{
    static void Main()
    {
        //Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).

        Console.Write("point x=");
        string input = Console.ReadLine();
        double pointX = double.Parse(input);
        Console.Write("point y=");
        input = Console.ReadLine();
        double pointY = double.Parse(input);

        //The algorithm is (x - center_x)^2 + (y - center_y)^2 < radius^2
        bool isInCircle = ((pointX - 0) * (pointX - 0)) + ((pointY - 0) * (pointY - 0)) <= (2 * 2);
        Console.WriteLine("The point with coordinates x={0} and y={1} is inside the circle -> {2}", pointX, pointY, isInCircle);
    }
}
