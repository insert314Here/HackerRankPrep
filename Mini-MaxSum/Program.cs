/* Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
 Then print the respective minimum and maximum values as a single line of two space-separated long integers. */

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long sumMin = 0;
        //minimum sum is 16 = 1+3+5+7
        //sort list from least to greatest
        arr.Sort();
        
        //adds the first 4 values
        for (int i = 0; i < arr.Count - 1; i++)
        {
            sumMin += arr[i];
        }

        //maximum sum is 24 = 3+5+7+9
        //sort list from greatest to least
        long sumMax = 0;
        arr.Reverse(); //sorts list from greatest to least
        for(int j = 0; j < arr.Count - 1; j++)
        {
            sumMax += arr[j];
        }

        //print out the mini-max values
        Console.WriteLine($"{sumMin} {sumMax}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        List<int> arr = new List<int>();
                        //arr.Add(3);
                        //arr.Add(1);
                        //arr.Add(7);
                        //arr.Add(5);
                        //arr.Add(9);

        arr.Add(256741038);
        arr.Add(623958417);
        arr.Add(467905213);
        arr.Add(714532089);
        arr.Add(938071625);



        Result.miniMaxSum(arr);
    }
}