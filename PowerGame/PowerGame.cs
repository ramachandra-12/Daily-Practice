using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T=int.Parse(Console.ReadLine());
        for(int t=0;t<T;t++)
        {
            int N=int.Parse(Console.ReadLine());
            string[] a=Console.ReadLine().Split(' ');
            string[] b=Console.ReadLine().Split(' ');
            int[] A=new int[N];
            int[] B=new int[N];
            for(int i=0;i<N;i++)
            {
                A[i]=int.Parse(a[i]);
            }
            for(int j=0;j<N;j++)
            {
                B[j]=int.Parse(b[j]);
            }
            Array.Sort(A);
            Array.Sort(B);
            int A_chance=0;
            int B_chance=0;
            int wins=0;
            while(A_chance<N && B_chance<N)
            {
                if(A[A_chance]>B[B_chance]){
                    wins++;
                    A_chance++;
                    B_chance++;
                }
                else{
                    A_chance++;
                }
            }
            Console.WriteLine(wins);
        }
    }
}