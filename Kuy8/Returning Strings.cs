using System;
//супер просто
/*
 Make a function that will return a greeting statement that uses an input; your program should return, "Hello, <name> how are you doing today?".

 [Make sure you type the exact thing I wrote or the program may not execute properly]
*/

public static class Kata
{
    public static string Greet(string name)
    {
        return $"Hello, {name} how are you doing today?";
    }
}

/*
 using System;

 public static class Kata
 {
   public static string Greet(string name) => $"Hello, {name} how are you doing today?";
 }
*/