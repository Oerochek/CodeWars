//класные задачи прикольно после часа мучений написать что то подобное
/*
 Description:
 Make a simple function called greet that returns the most-famous "hello world!".

 Style Points
 Sure, this is about as easy as it gets. But how clever can you be to create the most creative hello world you can think of? What is a "hello world" solution you would want to show your friends?
*/
public static class Kata
{
    public static string greet()
    {
        return "hello world!";
    }
}
/* лучший васа решеный евер
 using System;
 using System.Linq;

 public static class Kata
 {
   public static string greet()
   {
     string[] hello ={
    
                      "hhh   hhh  eeeeeeeee  lll        lll             ooo",        
                      "hhh   hhh  eeeeeeeee  lll        lll          ooo   ooo",    
                      "hhh   hhh  eee        lll        lll         ooo     ooo",    
                      "hhhhhhhhh  eeeeee     lll        lll        ooo       ooo", 
                      "hhhhhhhhh  eeeeee     lll        lll        ooo       ooo", 
                      "hhh   hhh  eee        lll        lll         ooo     ooo",    
                      "hhh   hhh  eeeeeeeee  lllllllll  lllllllll    ooo   ooo",    
                      "hhh   hhh  eeeeeeeee  lllllllll  lllllllll       ooo",      
                     
           "ww            w             w      ooo       rrrrrrrr     lll        dddddddd",         
            "ww           ww           w    ooo   ooo    rrr   rrr    lll        dddddddddd",       
             "ww         w ww         w    ooo     ooo   rrr    rrr   lll        ddd     ddd",     
              "ww       w   ww       w    ooo       ooo  rrr   rrr    lll        ddd      ddd",   
               "ww     w     ww     w     ooo       ooo  rrrrrrr      lll        ddd      ddd",  
                "ww   w       ww   w       ooo     ooo   rrr   rrr    lll        ddd     ddd",    
                 "ww w         ww w         ooo   ooo    rrr    rrr   lllllllll  dddddddddd ",    
                  "ww           ww             ooo       rrr     rrr  lllllllll  dddddddd "};
    
     string resString = String.Join("", String.Concat(hello).Replace(" ", "").GroupBy(x => x).Select(x => x.Key));
     return String.Concat(resString[0], resString[1], resString[2], resString[2], resString[3], " ", resString[4], resString[3], resString[5], resString[2], resString[6],"!");
   }
эт тоже
 public static class Kata
 {
   // Write a public static method "greet" that returns "hello world!"
   public static string greet()
   {
     // return string that says hello world
     return "hello world!";
   }
 }
 Best Practices10Clever1
  0ForkCompare with your solutionLink
 lost273
 public static class Kata
 {
   public static string greet()
   {
     string[] array = new string[]
     {
       $"{(char)104}{(char)101}{(char)108}{(char)108}{(char)111}",
       $"{(char)119}{(char)111}{(char)114}{(char)108}{(char)100}{(char)33}"
     };
     return string.Join(" ", array);
   }
 }
 Best Practices9Clever131
  5ForkCompare with your solutionLink
 Matt Smith
 using System;

 public static class Kata
 {
   public static string greet()
   {
         string baseSixtyFourString = 
         "aGVsbG8gd29ybGQhaGVsbG8gd29ybGQhaGVsbG8gd29ybGQhaGVsbG8gd29ybG" +
         "QhaGVsbG8gd29ybGQhaGVsbG8gd29ybGQhaGVsbG8gd29ybGQhaGhlbGxvIHdv" +
         "cmxkIWVoZWxsbyB3b3JsZCFsaGVsbG8gd29ybGQhbGhlbGxvIHdvcmxkIW9oZW" +
         "xsbyB3b3JsZCEgaGVsbG8gd29ybGQhd2hlbGxvIHdvcmxkIW9oZWxsbyB3b3Js" +
         "ZCFyaGVsbG8gd29ybGQhbGhlbGxvIHdvcmxkIWRoZWxsbyB3b3JsZCEhaGVsbG" +
         "8gd29ybGQhaGVsbG8gd29ybGQhaGVsbG8gd29ybGQhaGVsbG8gd29ybGQhaGVs" +
         "bG8gd29ybGQhaGVsbG8gd29ybGQhaGVsbG8gd29ybGQh";
         
         char[] baseSixtyFour = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 
         'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 
         'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 
         'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 
         'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '/' };
         
         int[] bSixFourToInt = new int[baseSixtyFourString.Length];
         int i = 0;
         foreach (char j in baseSixtyFourString)
             {
                 bSixFourToInt[i] = Array.IndexOf(baseSixtyFour, j);
                 i++;
             }
         string bitString = "";
         int[] b = { 32, 16, 8, 4, 2, 1 };
         foreach (int t in bSixFourToInt)
         {
             int k = 0;
             int x = t;
             while (k < 6)
                 {
                     if (x >= b[k])
                     {
                         bitString += "1";
                         x -= b[k];
                     }
                     else
                     {
                         bitString += "0";
                     }
                     k++;
                 }
         }
         string message = "";
         int w = 7;
         int z = 0;
         foreach (char m in bitString)
         {
             char p = m;
             if (p == '1') {z += (int)Math.Pow(2, w);}
             w -= 1;
             if (w < 0)
             {
                 message += (char)z;
                 w = 7;
                 z = 0;
             }
         }
         return message.Replace("hello world!", null);
        
     }
 }
*/