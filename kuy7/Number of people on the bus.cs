using System;
using System.Collections.Generic;

public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        int peopleIn = 0;
        int peopleOut = 0;
        for (int i = 0; i < peopleListInOut.Count; i++)
        {
            peopleIn += peopleListInOut[i][0];
            peopleOut += peopleListInOut[i][1];
        }
        return peopleIn - peopleOut;
    }
}
