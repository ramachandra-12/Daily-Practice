using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int N=int.Parse(Console.ReadLine()!);
        long result=Fact(N);
        Console.WriteLine(result);
    }
    static long Fact(int N)
    {
        if (N==0)
        {
            return 1;
        }
        else
        {
            return N*Fact(N-1);
        }
        
    }
}