﻿using System;
using System.Collections.Generic;
using System.IO;

class DataTypes
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        int a = Convert.ToInt32(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double res = d + b;
        string c = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + a);
        // Print the sum of the double variables on a new line.
        Console.WriteLine((d + b).ToString("#.0"));
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + c);
        // The 's' variable above should be printed first.
        Console.ReadKey();
    }
}