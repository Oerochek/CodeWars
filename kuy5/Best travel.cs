using System.Collections.Generic;
//здесь я собирал и подстраивал чужие куски кода под себя иначе я бы дольше писал свой код чем придумывал его и он все равно не работал
/*
 John and Mary want to travel between a few towns A, B, C ... Mary has on a sheet of paper a list of distances between these towns. ls = [50, 55, 57, 58, 60]. John is tired of driving and he says to Mary that he doesn't want to drive more than t = 174 miles and he will visit only 3 towns.

 Which distances, hence which towns, they will choose so that the sum of the distances is the biggest possible to please Mary and John?

 Example:
 With list ls and 3 towns to visit they can make a choice between: [50,55,57],[50,55,58],[50,55,60],[50,57,58],[50,57,60],[50,58,60],[55,57,58],[55,57,60],[55,58,60],[57,58,60].

 The sums of distances are then: 162, 163, 165, 165, 167, 168, 170, 172, 173, 175.

 The biggest possible sum taking a limit of 174 into account is then 173 and the distances of the 3 corresponding towns is [55, 58, 60].

 The function chooseBestSum (or choose_best_sum or ... depending on the language) will take as parameters t (maximum sum of distances, integer >= 0), k (number of towns to visit, k >= 1) and ls (list of distances, all distances are positive or zero integers and this list has at least one element). The function returns the "best" sum ie the biggest possible sum of k distances less than or equal to the given limit t, if that sum exists, or otherwise nil, null, None, Nothing, depending on the language. In that case with C, C++, D, Dart, Fortran, F#, Go, Julia, Kotlin, Nim, OCaml, Pascal, Perl, PowerShell, Reason, Rust, Scala, Shell, Swift return -1.

 Examples:
 ts = [50, 55, 56, 57, 58] choose_best_sum(163, 3, ts) -> 163

 xs = [50] choose_best_sum(163, 3, xs) -> nil (or null or ... or -1 (C++, C, D, Rust, Swift, Go, ...)

 ys = [91, 74, 73, 85, 73, 81, 87] choose_best_sum(230, 3, ys) -> 228

 Notes:
 try not to modify the input list of distances ls
 in some languages this "list" is in fact a string (see the Sample Tests).
*/
public static class SumOfK
{
    public static int? chooseBestSum(int t, int k, List<int> ls)
    {
        return findSum(k, t, ls, 1, 0, 0); ;
    }

    public static int? findSum(int depth, int goal, List<int> ls, int currentDepth, int listPosition, int currentSum)
    {
        int? bestSum = null;
        for (int i = listPosition; i < ls.Count - (depth - currentDepth); i++)
        {
            int? sum = null;
            if (currentDepth == depth)
                sum = currentSum + ls[i];
            else
                sum = findSum(depth, goal, ls, currentDepth + 1, i + 1, currentSum + ls[i]);

            if (sum <= goal && sum > (bestSum ?? 0))
                bestSum = sum;
        }
        return bestSum;
    }
}
/*звиздец как коротко
 using System;
 using System.Collections.Generic;
 using System.Linq;

 public static class SumOfK 
 {
   public static int? chooseBestSum(int t, int k, List<int> ls)
   {
     var _ls = ls.Where(x => x <= t);
     return _ls.Count() == 0 ? null : _ls.Select((x, i) => x + (k > 1 ? chooseBestSum(t-x, k-1, _ls.Skip(i+1).ToList()) : 0)).Max();
   }
 }

а вот нормальный

using System;
using System.Collections.Generic;

public static class SumOfK 
{
    public static int? chooseBestSum(int t, int k, List<int> ls) 
    {
      if(ls.Count < k) { return null; }
      
      int result = 0;
      
      int maxCount = CNM(ls.Count, k);
      
      int[] locate = new int[k];
      
      for(int i = 0; i < k; i++) { locate[i] = i; }
      
      List<int[]> path = new List<int[]>();
      
      path.Add(NArr(locate));
      
      while(true)
      {
        if(ls.Count == k) { break; }
        
        locate[k - 1]++;
        
        path.Add(NArr(locate));
        
        for(int x = k - 1; x >= 0; x--)
        {
          if(locate[x] != ls.Count - (k - x)) { continue; }
          
          if(x - 1 >= 0) { locate[x - 1]++; }
          
          for(int y = x; y <= k - 1; y++)
          {
            if(y - 1 >= 0) { locate[y] = locate[y - 1] + 1; }
          }
          
          path.Add(NArr(locate));
          
          if(locate[0] >= ls.Count - k) { break; }
        }
        
        if(locate[0] >= ls.Count - k) { break; }
      }
      
      int minus = -1;
      
      foreach(int[] nums in path)
      {
        int distance = 0;
        
        foreach(int num in nums) { distance += ls[num]; }
        
        if(distance > t) { continue; }
        
        if(distance == t) { result = distance; break;}
        
        int delta = Math.Abs(t - distance);
        
        if(minus != -1 && delta >= minus) { continue; }
        
        minus = delta;
        result = distance;
      }
      
      if(result == 0) { return null; }
      
      return result;
    }
  
    public static int CNM(int c, int k)
    {
      int up = c;
      
      for(int i = 1; i < k; i++)
      {
        up *= (c - i);
      }
      
      int down = 1;
      
      for(int i = 1; i <= k; i++)
      {
        down *= i;
      }
      
      int maxCount = up / down;
      
      return maxCount;
    }
  
    public static int[] NArr(int[] array)
    {
      int[] nArr = new int[array.Length];
      
      for(int i = 0; i < array.Length; i++) { nArr[i] = array[i]; }
    
      return nArr;
    }
}