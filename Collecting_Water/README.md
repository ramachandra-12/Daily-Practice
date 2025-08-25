#Collecting Water 


You are given the heights of N buildings. All the buildings are of width 1 and are adjacent to each other with no empty space in between. Assume that it is raining heavily, and as such water will be accumulated on top of certain buildings. Your task is to find the total amount of water accumulated.

Input Format
The first line of input contains T - the number of test cases. It's followed by 2T lines, the first line contains N - the number of buildings. The second line contains N elements denoting the height of the buildings.

Output Format
For each test case, print the units of water accumulated, separated by a new line.

Constraints
30 points
1 <= T <= 1000
1 <= N <= 1000
1 <= a[i] <= 1000

70 points
1 <= T <= 1000
1 <= N <= 100000
1 <= a[i] <= 1000

Example
Input
2
16
4 1 3 3 5 4 1 1 2 3 3 7 4 5 2 1
5
3 2 7 4 7 

Output
22
4

Explanation

Example 1:

Water accumulated on top of the buildings [1:3] = 5 (3+1+1)
Water accumulated on top of the buildings [5:10] = 16 (1+4+4+3+2+2)
Water accumulated on top of the buildings [12:12] = 1
Hence, the total amount of water accumulated on the buildings is 5 + 16 + 1 = 22.

Example 2:
Water accumulated on top of the buildings [2:2] = 1 
Water accumulated on top of the buildings [4:4] = 3 
Hence, the total amount of water accumulated on the buildings is 1 + 3 = 4.