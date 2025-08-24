using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int N=int.Parse(Console.ReadLine());
        int[] array=Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        Array.Sort(array);
        int Q=int.Parse(Console.ReadLine());
        for(int q=0;q<Q;q++)
        {
            int x=int.Parse(Console.ReadLine());
            int res=FindFloor(array,x);
            Console.WriteLine(res);
        }}
        static int FindFloor(int[] arr,int x)
        {
            int left=0,right=arr.Length-1;
            int ans=int.MinValue;
            while(left<=right)
            {
                int mid=(left+right)/2;
                if(arr[mid]==x)
                {
                    return arr[mid];
                }
                else if(arr[mid]<x)
                {
                    ans=arr[mid];
                    left=mid+1;
                }
                else{
                    right=mid-1;
                }
            }
            return ans;
        }
    }
