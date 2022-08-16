using System;
using System.Linq;


/*Task
Sum all the numbers of a given array ( cq. list ), except the highest and the lowest element ( by value, not by index! ).

The highest or lowest element respectively is a single element at each edge, even if there are more than one with the same value.

Mind the input validation.

Example
{ 6, 2, 1, 8, 10 } => 16
{ 1, 1, 11, 2, 3 } => 6
Input validation
If an empty value ( null, None, Nothing etc. ) is given instead of an array, or the given array is an empty list or a list with only 1 element, return 0.*/

public static class Kata
{
    public static int Sum(int[] numbers)
    {
        if (numbers == null || numbers.Length <= 1)
        {
            return 0;
        }

        return GetMaxAndMin(numbers);
        
    }

    static int GetMaxAndMin(int[] array)
    {
        int max = array[0];
        int min = array[0];
        int summa = 0;

        foreach (var number in array)
        {
            if (number > max)
            {
                max = number;
            }

            if (number < min)
            {
                min = number;
            }
            summa = summa + number;
        }
        
        summa = summa - max - min;
        return summa;
    }
}
