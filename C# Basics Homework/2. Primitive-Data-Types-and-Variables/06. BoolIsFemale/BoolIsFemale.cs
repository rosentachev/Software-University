using System;

class BoolIsFemale
{
    static void Main()
    {
        //Declare a Boolean variable called isFemale and assign an appropriate value 
        //corresponding to your gender. Print it on the console.

        char female = 'f';
        char myGender = 'm';
        bool isFemale = female == myGender;
        Console.WriteLine("I am female -> {0}", isFemale);
    }
}
