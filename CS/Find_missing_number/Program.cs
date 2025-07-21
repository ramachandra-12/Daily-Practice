using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T=int.Parse(Console.ReadLine());
        
        for(int t=0;t<T;t++)
        {
            int sum=0;
            int N=int.Parse(Console.ReadLine());
            string[] token=Console.ReadLine().Split(' ');
            int[] array=new int[N];
            for(int x=0;x<N;x++)
            {
                array[x]=int.Parse(token[x]);
                sum+=array[x];
            }
            int formulaSum=((N+1)*(N+2))/2;
            Console.WriteLine(formulaSum-sum);
        }
    }
}