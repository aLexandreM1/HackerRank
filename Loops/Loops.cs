﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Loops
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}