using System;

class PrintCompanyInfo
{
    static void Main()
    {
        //A company has name, address, phone number, fax number, web site and manager. 
        //The manager has first name, last name, age and a phone number. 
        //Write a program that reads the information about a company and 
        //its manager and prints it back on the console.

        //company info
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Company phone: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Company fax: ");
        string companyFax = Console.ReadLine();
        Console.Write("Web site: ");
        string companySite = Console.ReadLine();

        //manager info
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        //print all information
        Console.WriteLine("\r\nInformation about company\r\n{0}", new string ('-', 35));
        Console.WriteLine("Name - {0}\r\nAddress - {1}\r\nPhone number - {2}\n\rFax number - {3}\r\nWeb site - {4}",
                            companyName, companyAddress, companyPhone, companyFax, companySite);
        Console.WriteLine("\r\nInformation about company manager\r\n{0}", new string ('-', 35));
        Console.WriteLine("First name - {0}\r\nLast name - {1}\r\nAge - {2}\r\nPhone number - {3}",
                            managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
