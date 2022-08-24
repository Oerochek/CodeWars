using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Program
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            int[] nul = new int[] { };
            if (input == null || input.Length == 0)
                return nul;

            else
            {
                int sumnegative = 0;
                int poscount = 0;
                foreach (int i in input)
                {
                    if (i > 0)
                    {
                        poscount++;
                    }
                    else if (i < 0)
                    {
                        sumnegative += input[i - 1];
                    }
                }
                int[] result = new int[] { poscount, sumnegative };
                Console.WriteLine(result);
                return result;
            }
        }
    }
}
