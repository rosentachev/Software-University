using System;

class BankAccountData
{
    static void Main()
    {
        //A bank account has a holder name (first name, middle name and last name), 
        //available amount of money (balance), bank name, IBAN, 3 credit card numbers 
        //associated with the account. Declare the variables needed to keep the information 
        //for a single bank account using the appropriate data types and descriptive names.

        string firstName = "Pesho";
        string middleName = "Ivanov";
        string lastName = "Petrov";
        string nameHolder = firstName + " " + middleName + " " + lastName;
        decimal balance = 8450.00M;
        string bankName = "DSK Bank";
        string IBAN = "BG52STSA93000020871234";
        string firstCard = "5588 3201 2345 6789";
        string secondCard = "1234 9876 5678 5432";
        string thirdCard = "6229 4688 4732 5679";
    }
}
