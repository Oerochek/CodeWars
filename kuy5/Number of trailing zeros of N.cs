using System;
/*
 * вот тут пришлось попотеть с поиском инфы про подобные матемотические задачи в реальной жизни

 Write a program that will calculate the number of trailing zeros in a factorial of a given number.

 N! = 1 * 2 * 3 *  ... * N

 Be careful 1000! has 2568 digits...

 For more info, see: http://mathworld.wolfram.com/Factorial.html

 Examples
 zeros(6) = 1
 # 6! = 1 * 2 * 3 * 4 * 5 * 6 = 720 --> 1 trailing zero

 zeros(12) = 2
 # 12! = 479001600 --> 2 trailing zeros
 Hint: You're not meant to calculate the factorial. Find another way to find the number of zeros.
*/
public static class Kata
{
    public static int TrailingZeros(int num)
    {
        int zeros = 0;
        while (num > 0)
        {
            num /= 5;
            zeros += num;
        }
        return zeros;
    }
}
/*
 using System;
 using System.Linq;

 public static class Kata 
 {
   public static int TrailingZeros(int n) => Enumerable.Range(1, (int)Math.Log(n, 5)).Sum(i => (int)(n / Math.Pow(5, i)));
 }
*/