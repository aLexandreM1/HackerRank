using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Operators
{
    static void Main(String[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine());
        int tip_percent = Convert.ToInt32(Console.ReadLine());
        int tax_percent = Convert.ToInt32(Console.ReadLine());
        double resulta = meal_cost * tip_percent / 100;
        double resultb = meal_cost * tax_percent / 100;
        Console.WriteLine("The total meal cost is " + Math.Round(meal_cost + resultb + resulta) + " dollars.");
        Console.ReadLine();
    }
}