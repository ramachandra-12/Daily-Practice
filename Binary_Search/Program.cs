using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] input=Console.ReadLine().Split();
        int N=int.Parse(input[0]);
        int k=int.Parse(input[1]);
        int[] array=Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int low=0,high=N-1;
        bool target=false;
        while(low<=high)
        {
            int mid=(low+high)/2;
            Console.WriteLine($"{low} {high} {mid}");

            if (array[mid]==k)
            {
                target=true;
                break;
            }
            else if (array[mid]<k)
            {
                low=mid+1;
            }
            else{
                high=mid-1;
            }

        }
        Console.WriteLine(target? "True" : "False");
    }
}