﻿using System;

class UseOfQuatation
{
    static void Main()
    {
        //Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
        //Do the above in two different ways: with and without using quoted strings.
        //Print the variables to ensure that their value was correctly defined.

        string withoutQuatation = "The \"use\" of quatations causes difficulties.";
        string withQuatation = @"The ""use"" of quatations causes difficulties.";
        Console.WriteLine("Non quoted string: {0}\nQuoted string: {1}", withoutQuatation, withQuatation);
    }
}
