//сори у меня закрылась предыдущая задача решил новую таково же уровня и да код не мой но у меня было тоже самое только я не мог вернуть длину и по запросу в гугле выдало это
/*
 Simple, given a string of words, return the length of the shortest word(s).

 String will never be empty and you do not need to account for different data types.
*/

using System.Linq;
public class Kata
{
    public static int FindShort(string str)
    {
        string min = str.Split().OrderBy(s => s.Length).FirstOrDefault();
        return min.Length;
    }
}

/*
 using System.Linq;
 public class Kata
 {
   public static int FindShort(string s)
   {
     return s.Split(' ').Min(x => x.Length);
   }
 }
*/