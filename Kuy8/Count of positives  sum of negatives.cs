using System;
using System.Collections.Generic;
using System.Linq;

/*
 Given an array of integers.

 Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.

 If the input is an empty array or is null, return an empty array.

 Example
 For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].
*/
public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        int[] nul = new int[] { };
        if (input == null || input.Length == 0)
            return nul;

        else
        {
            int sumnegative = 0;
            int poscount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (0 < input[i])
                {
                    poscount++;
                }
                else if (input[i] < 0)
                {
                    sumnegative += input[i];
                }
            }
            int[] result = new int[] { poscount, sumnegative };
            return result;
        }
    }
}

/*
 using System;
 using System.Collections.Generic;
 using System.Linq;

 public class Kata
 {
     public static int[] CountPositivesSumNegatives(int[] input)
     {
         if(input == null || !input.Any())
         {
             return new int[] {};
         }
        
         int countPositives = input.Count(n => n > 0);
         int sumNegatives = input.Where(n => n < 0).Sum();
 
         return new int[] { countPositives, sumNegatives };
     }
 }
*/