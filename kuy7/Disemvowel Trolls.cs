// no works(((
/*
 Trolls are attacking your comment section!

 A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

 Your task is to write a function that takes a string and return a new string with all vowels removed.

 For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

 Note: for this kata y isn't considered a vowel.
*/
using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        str.ToCharArray();
        char[] volveCH = new char[] { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < volveCH.Length; j++)
            {
                if (str[i] == volveCH[j])
                {
                    const char V = '';
                    _ = str.Replace(str[i], V);
                }
            }
        }
        return str;
    }
}