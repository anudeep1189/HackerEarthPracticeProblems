/* Problem statement
Monk loves to preform different operations on arrays, and so being the principal of Hackerearth School, he assigned a task to his new student Mishki. Mishki will be provided with an integer array A of size N and an integer K , where she needs to rotate the array in the right direction by K steps and then print the resultant array. As she is new to the school, please help her to complete the task.

Input:
The first line will consists of one integer T denoting the number of test cases.
For each test case:
1) The first line consists of two integers N and K, N being the number of elements in the array and K denotes the number of steps of rotation.
2) The next line consists of N space separated integers , denoting the elements of the array A.

Output:
Print the required array.
*/

/*
sample input
1
5 2
1 2 3 4 5
sample output
4 5 1 2 3
*/


//code below


using System;
  class Program
    {
        static void Main(string[] args)
        {          
            int t = Convert.ToInt32(Console.ReadLine()); //no of test cases
            for(int tt = 0 ; tt < t ; tt++)
            {              
                //Element length and rotation , this is done for formatting the input , or else we will get error
                string[] strNAndK = Console.ReadLine().Split(' ');                
                //array user input
                string[] strArray = Console.ReadLine().Split(' '); 

                int n = Int32.Parse(strNAndK[0]);
                int k = Int32.Parse(strNAndK[1]);

                k = k%n; //eg 2%5 = 2
                string[] resultArry = new string[n]; //array to store result
                for(int i = 0; i < n ; i++ )
                {
                  resultArry[i] = strArray[(i+(n-k))%n];      //eg (0+(5-2))%5 = 3, and so on for each iteration

                }
                Console.WriteLine(string.Join(" ", resultArry));
              
              
                //alternative method but slow
                // string lstArrElem;
                // for (int j = 0; j < k; j++) // no of rotation
                // {
                //     lstArrElem = strArray[n - 1];//save the last element of the array,or else it will be lost 
                //     for (int i = n - 1; i > 0; i--) // move array element from right to left
                //     {
                //         strArray[i] = strArray[i - 1];
                //     }
                //     strArray[0] = lstArrElem; //saved last value will be placed in the beginning of the array
                // }
                // //print result in horizontal format
                // Console.WriteLine(string.Join(" ", strArray));    
                
            }            
        }
    }