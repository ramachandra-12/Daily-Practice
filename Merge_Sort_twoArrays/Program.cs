using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(string[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int N=int.Parse(Console.ReadLine());
        string[] numbers1=Console.ReadLine().Split(' ');
        int[] Array1=new int[N];
        for (int i=0;i<N;i++)
        {
            Array1[i]=int.Parse(numbers1[i]);
        }
        int M=int.Parse(Console.ReadLine());
        string[] num2=Console.ReadLine().Split(' ');
        int[] Array2=new int[M];
        for (int i=0;i<M;i++)
        {
            Array2[i]=int.Parse(num2[i]);
        }
        int[] merged=new int[Array1.Length+Array2.Length];
        for (int i=0;i<Array1.Length;i++)
        {
            merged[i]=Array1[i];
        }
        for (int i=0;i<Array2.Length;i++)
        {
            merged[Array1.Length+i]=Array2[i];
        }
        Array.Sort(merged);
        Console.WriteLine(string.Join(" ",merged));


    }
}