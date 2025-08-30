using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T=int.Parse(Console.ReadLine());
        for (int t=1;t<=T;t++)
        {
            int N=int.Parse(Console.ReadLine());
            int size=2*N;
            Console.WriteLine($"Case #{t}:");
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size;j++)
                {
                    int row=i/2;
                    int col=j/2;
                    if((row+col)%2==0)
                    {
                        Console.Write("*");
                    }
                    else{
                        Console.Write("-");
                    }

                }
                Console.WriteLine();
            }
            
        }
    }
}