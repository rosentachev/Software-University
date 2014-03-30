using System;

class IsPointInCircleAndOutRectangle
{
    static void Main()
    {
        //Write an expression that checks for given point (x, y) if it is within the 
        //circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

        Console.Write("point x=");
        string input = Console.ReadLine();
        double pointX = double.Parse(input);
        Console.Write("point y=");
        input = Console.ReadLine();
        double pointY = double.Parse(input);

        bool isInCircle = ((pointX - 1) * (pointX - 1)) + ((pointY - 1) * (pointY - 1)) <= (1.5 * 1.5);
        bool isInRectangle = (pointX >= -1 && pointX <= 5) && (pointY >= -1 && pointY <= 1);

        if (isInCircle == true && isInRectangle == false)
        {
            Console.WriteLine("inside K & outside of R -> yes");
        }
        else
        {
            Console.WriteLine("inside K & outside of R - > no");
        }
    }
}
