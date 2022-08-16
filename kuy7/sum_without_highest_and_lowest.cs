using System;
using System.Linq;

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
