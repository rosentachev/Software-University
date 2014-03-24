using System;

class EmployeeData
{
    static void Main()
    {
        //A marketing company wants to keep record of its employees. 
        //Each record would have the following characteristics: First Name, Last Name, 
        //Age (0...100), Gender (m or f), Personal ID number (e.g. 8306112507), 
        //Unique employee number (27560000…27569999). Use descriptive names. Print the data at the console.

        string firstName = "Rosen";
        string lastName = "Tachev";
        byte age = 20;
        char gender = 'm';
        long idNumber = 8306112507;
        int uniqueNumber = 27560001;
        Console.WriteLine("First employee information:\n{0}\nFirst name: {1}\nLast Name: {2}\n"
                          + "Age: {3}\nGender: {4}\nPersonal ID Number: {5}\nUnique number: {6}",
                          new string ('-', 35), firstName, lastName, age, gender, idNumber, uniqueNumber);
    }
}
