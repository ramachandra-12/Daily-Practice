using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int T=int.Parse(Console.ReadLine());
        for(int t=0;t<T;t++)
        {
            string vowels="aeiou";
            while(T-->0)
            {
                string s=Console.ReadLine();
                int max=0,current=0;
                foreach(char c in s)
                {
                    if(vowels.IndexOf(c)==-1)
                    {
                        current++;
                        max=Math.Max(max,current);
                    }
                    else{
                        current=0;
                    }
                }
                Console.WriteLine(max);
            }
            
        }
    }
}