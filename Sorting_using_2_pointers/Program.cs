using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T=int.Parse(Console.ReadLine());
        for(int t=0;t<T;t++)
        {
            int N=int.Parse(Console.ReadLine());
            int[] array=Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int left=0,right=N-1;
            while(left<right)
            {
                if(array[left]==0)
                {
                    left++;
                }
                else if(array[right]==1)
                {
                    right--;
                }
                else{
                    int temp=array[left];
                    array[left]=array[right];
                    array[right]=temp;
                }
            }
            Console.WriteLine(String.Join(" ",array));
        }
    }
}