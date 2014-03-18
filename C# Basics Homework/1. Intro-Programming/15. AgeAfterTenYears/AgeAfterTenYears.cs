using System;

class AgeAfterTenYears
{
    static void Main()
    {
        //Write a program to read your birthday from the console and 
        //print how old you are now and how old you will be after 10 years.

        Console.Write("Please enter your birthday in format (dd.mm.yyyy): ");
        string input = Console.ReadLine();
        DateTime birthDay = DateTime.Parse(input);
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - birthDay.Year;

        if (birthDay.Month > currentDate.Month || birthDay.Month == currentDate.Month && birthDay.Day > currentDate.Day)
        {
            age--;
        }

        Console.WriteLine("You are {0} years old.", age);
        Console.WriteLine("After 10 years you will be {0} years old.", age + 10);
    }
}
