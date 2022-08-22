using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
/*крч я забыл добавить и оформить это
 поэтому расскажу так: тут надо было найти минимальное и максимальное число в стороке, именно строке с числами разделенных пробелом,
 а потом вернуть их(числа) в виде строки
*/

public static class Kata
{

    public static string HighAndLow(string numbers)
    {
        var numberArray = StringToIntArray(numbers);
        var max = numberArray.Max();
        var min = numberArray.Min();
        return max + " " + min;
    }

    private static List<int> StringToIntArray(string numbersString)
    {
        var stringList = numbersString.ToList();
        var numbersList = new List<int>();
        for (int i = 0; i < stringList.Count(); i++)
        {
            if (numbersString[i].Equals('-'))
            {
                string negativeNumber = numbersString[i].ToString() + MulitpleDigitNumberExtraction(numbersString, ref i);
                numbersList.Add(int.Parse(negativeNumber, NumberStyles.Any));
                i++;
            }
            else if (Char.IsDigit(numbersString[i]))
            {
                string numbers = numbersString[i].ToString();
                numbers += MulitpleDigitNumberExtraction(numbersString, ref i);
                numbersList.Add(int.Parse(numbers));
            }
        }
        return numbersList;
    }

    private static string MulitpleDigitNumberExtraction(string numbersString, ref int i)
    {
        bool nextCharIsDigit = true;
        string numbers = "";
        while (nextCharIsDigit)
        {
            if (i + 1 == numbersString.Count())
            {
                break;
            }
            if (Char.IsDigit(numbersString[i + 1]))
            {
                numbers += numbersString[i + 1];
                i++;
            }
            else
            {
                nextCharIsDigit = false;
            }
        }
        return numbers;
    }
}