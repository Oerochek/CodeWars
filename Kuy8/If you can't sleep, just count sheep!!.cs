using System;
using System.Collections.Generic;
using System.Linq;

/*
 DESCRIPTION:
 If you can't sleep, just count sheep!!

 Task:
 Given a non-negative integer, 3 for example, return a string with a murmur: "1 sheep...2 sheep...3 sheep...". Input will always be valid, i.e. no negative integers.
*/
public static class Kata
{
    public static string CountSheep(int n)
    {
        string resultat = "";
        for (int i = 1; i <= n; i++)
        {
            resultat += $"{i} sheep...";
        }
        return resultat;
    }
}
/*
 using System.Linq;

 public static class Kata
 {
   public static string CountSheep(int n)
   {
     return string.Concat(Enumerable.Range(1, n).Select(i => $"{i} sheep..."));
   }
 }
*/