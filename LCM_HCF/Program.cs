using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) 
    {
        int T=int.Parse(Console.ReadLine());
        for (int t=0;t<T;t++)
        {
            string[] tokens=Console.ReadLine().Split();
            int A=int.Parse(tokens[0]);
            int B=int.Parse(tokens[1]);
            int HCF=gcd(A,B);
            long LCM=((long)A*B)/HCF;
            Console.WriteLine($"{LCM} {HCF}");
            
        }

    }
    static int gcd(int a,int b)
    {
        if (b==0)
        {
            return a;
        }
        else{
            return gcd(b,a%b);
        }

    } 
}
