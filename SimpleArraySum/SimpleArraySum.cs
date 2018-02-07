using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class SimpleArraySumAlgorithm
{

    static int SimpleArraySum(int n, int[] ar)
    {
        return ar.Sum();
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = SimpleArraySum(n, ar);
        Console.WriteLine(result);
    }
}