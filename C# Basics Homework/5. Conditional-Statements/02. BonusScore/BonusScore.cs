﻿using System;

class BonusScore
{
    static void Main()
    {
        //Write a program that applies bonus score to given score in the range [1…9] by the following rules:
        //If the score is between 1 and 3, the program multiplies it by 10.
        //If the score is between 4 and 6, the program multiplies it by 100.
        //If the score is between 7 and 9, the program multiplies it by 1000.
        //If the score is 0 or more than 9, the program prints “invalid score”.

        Console.Write("Enter your score: ");
        string input = Console.ReadLine();
        int score = int.Parse(input);

        switch (score)
        {
            case 1:
            case 2:
            case 3:
                score *= 10;
                Console.WriteLine("After the bonus your score will be {0} points.", score);
                break;
            case 4:
            case 5:
            case 6:
                score *= 100;
                Console.WriteLine("After the bonus your score will be {0} points.", score);
                break;
            case 7:
            case 8:
            case 9:
                score *= 1000;
                Console.WriteLine("After the bonus your score will be {0} points.", score);
                break;
            default:
                Console.WriteLine("Invalid score!");
                break;
        }
    }
}
