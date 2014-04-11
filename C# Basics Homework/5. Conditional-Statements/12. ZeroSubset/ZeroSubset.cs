using System;

class ZeroSubset
{
    static void Main()
    {
        //We are given 5 integer numbers. Write a program that finds all subsets 
        //of these numbers whose sum is 0. Assume that repeating the same subset 
        //several times is not a problem.

        Console.WriteLine("Enter five integer numbers (on separate lines)");
        string input = Console.ReadLine();
        int firstNumber = int.Parse(input);
        input = Console.ReadLine();
        int secondNumber = int.Parse(input);
        input = Console.ReadLine();
        int thirdNumber = int.Parse(input);
        input = Console.ReadLine();
        int fourthNumber = int.Parse(input);
        input = Console.ReadLine();
        int fifthNumber = int.Parse(input);

        Console.WriteLine("zero subset numbers: ");
        //five numbers
        if (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }

        //four numbers
        if (secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }
        if (firstNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, thirdNumber, fourthNumber, fifthNumber);
        }
        if (firstNumber + secondNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, fourthNumber, fifthNumber);
        }
        if (firstNumber + secondNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, thirdNumber, fifthNumber);
        }
        if (firstNumber + secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, thirdNumber, fourthNumber);
        }

        //three numbers
        if (thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", thirdNumber, fourthNumber, fifthNumber);
        }
        if (secondNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, fourthNumber, fifthNumber);
        }
        if (secondNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, thirdNumber, fifthNumber);
        }
        if (secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, thirdNumber, fourthNumber);
        }
        if (firstNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, fourthNumber, fifthNumber);
        }
        if (firstNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, thirdNumber, fifthNumber);
        }
        if (firstNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, thirdNumber, fourthNumber);
        }
        if (firstNumber + secondNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, fifthNumber);
        }
        if (firstNumber + secondNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, fourthNumber);
        }
        if (firstNumber + secondNumber + thirdNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, thirdNumber);
        }

        //two numbers
        if (firstNumber + secondNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNumber, secondNumber);
        }
        if (firstNumber + thirdNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNumber, thirdNumber);
        }
        if (firstNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNumber, fourthNumber);
        }
        if (firstNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNumber, fifthNumber);
        }
        if (secondNumber + thirdNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNumber, thirdNumber);
        }
        if (secondNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNumber, fourthNumber);
        }
        if (secondNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNumber, fifthNumber);
        }
        if (thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdNumber, fourthNumber);
        }
        if (thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdNumber, fifthNumber);
        }
        if (fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", fourthNumber, fifthNumber);
        }
    }
}
