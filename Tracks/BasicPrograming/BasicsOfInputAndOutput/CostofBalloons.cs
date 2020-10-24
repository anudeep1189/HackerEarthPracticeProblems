/*
 Problem Statement
You are conducting a contest at your college. This contest consists of two problems and

participants. You know the problem that a candidate will solve during the contest.

You provide a balloon to a participant after he or she solves a problem. There are only green and purple-colored balloons available in a market. Each problem must have a balloon associated with it as a prize for solving that specific problem. You can distribute balloons to each participant by performing the following operation:

    Use green-colored balloons for the first problem and purple-colored balloons for the second problem
    Use purple-colored balloons for the first problem and green-colored balloons for the second problem

You are given the cost of each balloon and problems that each participant solve. Your task is to print the minimum price that you have to pay while purchasing balloons.
 
//Sample Input and Output
Input           
2                   
9 6
10
1 1
1 1
0 1
0 0
0 1
0 0
0 1
0 1
1 1
0 0
1 9
10
0 1
0 0
0 0
0 1
1 0
0 1
0 1
0 0
0 1
0 0
 
Ouput 
69
14
 
 */

// Write your code here
using System;


class Program
{
    public static void Main(string[] args)
    {
        //user input
        //test case
        int t = Int32.Parse(Console.ReadLine());

        while (t != 0)
        {
            t--;
            //variable for operations
            int result1, result2;
            result1 = result2 = 0;

            //cost
            string[] bandp = (Console.ReadLine()).Split(' ');

            int blue = Int32.Parse(bandp[0]);
            int purple = Int32.Parse(bandp[1]);
            //array size
            int arrSize = Int32.Parse(Console.ReadLine());

            string[] arrElement = new string[arrSize];

            //create input array       
            string[,] inputArr = new string[arrSize, 2];

            for (int i = 0; i < arrSize; i++)
            {
                arrElement[i] = Console.ReadLine();

                for (int j = 0; j < 2; j++)
                {
                    inputArr[i, j] = arrElement[i].Split(' ')[j];
                }
            }
            for (int j = 0; j < arrSize; j++)
            {
                //Console.WriteLine("{0}", inputArr[j,i]);
                if (inputArr[j, 0].Equals("1"))
                { result1++; }

                if (inputArr[j, 1].Equals("1"))
                { result2++; }
            }
            int total1 = (result1 * blue) + (result2 * purple);
            int total2 = (result1 * purple) + (result2 * blue);
            Console.WriteLine(Math.Min(total1, total2));
        }
    }
}

