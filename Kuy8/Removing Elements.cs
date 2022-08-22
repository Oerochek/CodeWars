/*
 Take an array and remove every second element from the array. Always keep the first element and start removing with the next element.

 Example:
 ["Keep", "Remove", "Keep", "Remove", "Keep", ...] --> ["Keep", "Keep", "Keep", ...]

 None of the arrays will be empty, so you don't have to worry about that!
*/
public static class Kata
{
    public static object[] RemoveEveryOther(object[] arr)
    {

        object[] result;
        if (arr.Length % 2 != 0)
        {
            result = new object[arr.Length / 2 + 1];
        }
        else
        {
            result = new object[arr.Length / 2];
        }

        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                result[j] = arr[i];
                j++;
            }
        }
        return result;
    }
}
/*
 using System.Linq;

 public static class Kata
 {
     public static object[] RemoveEveryOther(object[] arr)
     {
         return arr.Where((e, i) => i%2 == 0).ToArray();
     }
 }
*/