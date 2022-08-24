using System;
/*
 Finish the solution so that it sorts the passed in array of numbers. If the function passes in an empty array or null/nil value then it should return an empty array.

 For example:

 SortNumbers(new int[] { 1, 2, 10, 50, 5 }); // should return new int[] { 1, 2, 5, 10, 50 }
 SortNumbers(null); // should return new int[] { }
*/
public class Kata
{
    public static int[] SortNumbers(int[] nums)
    {
        if (nums == null)
            nums = new int[0];

        Array.Sort(nums);
        return nums;
    }
}
/*
 using System.Linq;

 public class Kata
 {
     public static int[] SortNumbers(int[] nums)
     {
         return nums == null || !nums.Any() ? new int[] { } : nums.OrderBy(n => n).ToArray();
     }
 }
*/