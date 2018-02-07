using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    private static long result;

    static long aVeryBigSum(int n, long[] ar) 
    {
        for(int i = 0; i < n; i++)
        {
            result = ar.Sum();
        }
            return ar.Sum();
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        long[] ar = Array.ConvertAll(ar_temp,Int64.Parse);
        long result = aVeryBigSum(n, ar);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
