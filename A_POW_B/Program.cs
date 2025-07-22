using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T=int.Parse(Console.ReadLine());
        long m=1000000007;
        for (int i=0;i<T;i++)
        {
        
            long ans=1;
            string[] AB=Console.ReadLine().Split();
            long A=long.Parse(AB[0]);
            int B=int.Parse(AB[1]);
            A=A%m;
            while(B>0)
            {
                int x=B&1;
                if(x==1)
                {
                    ans=(ans*A)%m;
                }
                A=(A*A)%m;
                B=B>>1;
            }
            Console.WriteLine(ans);
            
        }
    }
}