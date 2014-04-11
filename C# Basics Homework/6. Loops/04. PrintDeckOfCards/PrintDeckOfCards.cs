using System;

class PrintDeckOfCards
{
    static void Main()
    {
        //Write a program that generates and prints all possible cards from 
        //a standard deck of 52 cards (without the jokers). The cards should 
        //be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). 
        //The card faces should start from 2 to A. Print each card face in its 
        //four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

        int spades = 9824;
        int hearts = 9829;
        int diams = 9830;
        int clubs = 9827;

        for (int i = 2; i < 15; i++)
        {
            if (i > 1 && i < 11)
            {
                Console.WriteLine("{0}" + (char)spades + " " +
                                  "{0}" + (char)hearts + " " +
                                  "{0}" + (char)diams + " " +
                                  "{0}" + (char)clubs + " ", i);
            }
            else
            {
                for (i = 11; i < 15; i++)
                {
                    switch (i)
                    {
                        case 11: Console.WriteLine("J" + (char)spades + " " +
                                                   "J" + (char)hearts + " " +
                                                   "J" + (char)diams + " " +
                                                   "J" + (char)clubs + " ");
                            break;
                        case 12: Console.WriteLine("D" + (char)spades + " " +
                                                   "D" + (char)hearts + " " +
                                                   "D" + (char)diams + " " +
                                                   "D" + (char)clubs + " ");
                            break;
                        case 13: Console.WriteLine("K" + (char)spades + " " +
                                                   "K" + (char)hearts + " " +
                                                   "K" + (char)diams + " " +
                                                   "K" + (char)clubs + " ");
                            break;
                        case 14: Console.WriteLine("A" + (char)spades + " " +
                                                   "A" + (char)hearts + " " +
                                                   "A" + (char)diams + " " +
                                                   "A" + (char)clubs + " ");
                            break;
                    }
                }
            }
        }
    }
}
