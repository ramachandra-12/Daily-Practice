using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int N=int.Parse(Console.ReadLine());
        for(int i=1;i<=10;i++)
        {
            int prod=N*i;
            Console.WriteLine($"{N} * {i} = {prod}");
        }
    }
}