using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        int T=int.Parse(Console.ReadLine());
        for(int t=0;t<T;t++)
        {
            int N=int.Parse(Console.ReadLine());
            long[] array=Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
            long sumOfAll=array.Sum();
            long sumOfEach=array.Distinct().Sum();
            long unique=(3*sumOfEach-sumOfAll)/2;
            Console.WriteLine(unique);
        }    
    }
}