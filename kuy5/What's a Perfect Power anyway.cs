using System;
/*
 A perfect power is a classification of positive integers:

 In mathematics, a perfect power is a positive integer that can be expressed as an integer power of another positive integer. More formally, n is a perfect power if there exist natural numbers m > 1, and k > 1 such that mk = n.

 Your task is to check wheter a given integer is a perfect power. If it is a perfect power, return a pair m and k with mk = n as a proof. Otherwise return Nothing, Nil, null, NULL, None or your language's equivalent.

 Note: For a perfect power, there might be several pairs. For example 81 = 3^4 = 9^2, so (3,4) and (9,2) are valid solutions. However, the tests take care of this, so if a number is a perfect power, return any pair that proves it.

 Examples
 IsPerfectPower(4) => (2,2)
 IsPerfectPower(5) => null
 IsPerfectPower(8) => (2,3)
 IsPerfectPower(9) => (3,2)
*/
public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        for (int i = 2; i * i <= n; i++)
        {
            for (int j = 2; Math.Pow(i, j) <= n; j++)
            {
                if (Math.Pow(i, j) == n)
                {
                    return (i, j);
                }
            }
        }

        return null;
    }
}
/*
 using System;
 public class PerfectPower
 {
     public static (int, int)? IsPerfectPower(int n)
     {
        for (var m = 2; m * m <= n; ++m)
             for (var k = 2; Math.Pow(m, k) <= n; ++k)
             if (Math.Pow(m, k) == n) return (m, k);
             return null;
     }
 }
*/