using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T=int.Parse(Console.ReadLine());
        for(int t=0;t<T;t++)
        {
            uint N=uint.Parse(Console.ReadLine());
            uint rev=0;
            for(int i=0;i<32;i++)
            {
                rev=(rev<<1)|(N&1U);
                N>>=1;
            }
            Console.WriteLine(rev);
        }
        
            
        }
}