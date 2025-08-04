using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T=int.Parse(Console.ReadLine());
        for(int t=0;t<T;t++)
        {
            int N=int.Parse(Console.ReadLine());
            string[] tokens=Console.ReadLine().Split(' ');
            int[] array=new int[N];
            for(int i=0;i<N;i++)
            {
                array[i]=int.Parse(tokens[i]);
            }
            for(int i=N-1;i>=1;i--)
            {
                int maxIndex=0;
                for(int j=1;j<=i;j++)
                {
                    if (array[j]>array[maxIndex])
                    {
                        maxIndex=j;
                    }
                }
                if (maxIndex!=i){
                    int temp=array[i];
                    array[i]=array[maxIndex];
                    array[maxIndex]=temp;
                }
                Console.Write(maxIndex+ " ");
            
            }
            Console.WriteLine();
        }
    }
}