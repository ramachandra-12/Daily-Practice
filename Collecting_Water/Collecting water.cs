using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T=int.Parse(Console.ReadLine());
        for(int t=0;t<T;t++)
        {
            int N=int.Parse(Console.ReadLine());
            int[] arr=Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int left=0,right=N-1;
            int leftMax=0,rightMax=0;
            int totalWater=0;
            while(left<=right)
            {
                if(arr[left]<arr[right])
                {
                    if (arr[left]>=leftMax)
                    {
                        leftMax=arr[left];
                    }
                    else{
                        totalWater+=leftMax-arr[left];
                    }
                    left++;
                }
                else{
                    if(arr[right]>=rightMax)
                    {
                        rightMax=arr[right];
                    }
                    else{
                        totalWater+=rightMax-arr[right];
                    }
                    right--;
                }
            }
            Console.WriteLine(totalWater);

        }    
    }
}