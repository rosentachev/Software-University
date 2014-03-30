using System;

class MoonGravitation
{
    static void Main()
    {
        //The gravitational field of the Moon is approximately 17% of that on the Earth. 
        //Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

        Console.Write("Please enter your weight on the Earth: ");
        string input = Console.ReadLine();
        double earthWeight = double.Parse(input);
        double moonWeight = (earthWeight * 17) / 100;
        Console.WriteLine("Your weight on the moon will be: {0}", moonWeight);
    }
}
