using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            do
            {
                string origanal = Console.ReadLine();
                if (origanal.Length < 1)
                    break;
                char[] low = origanal.ToLower().ToCharArray();
                bool[] mask = new bool[low.Length];
                bool[] maskStep = new bool[low.Length];
                char[] UP = origanal.ToUpper().ToCharArray();
                int CountLetter = 0;
                for (int i = 0; i < low.Length; i++)
                {
                    mask[i] = low[i] == UP[i];
                    if (mask[i])
                        CountLetter++;
                }
                int CountNew = ((int)Math.Pow(2, CountLetter)) + 1;
                char[,] newString = new char[CountNew, low.Length];
                //int c = 0;
                for (int c = 0; c < CountNew; c++)
                //for (int k = 0; k < low.Length; k++)
                {
                    int k = -1,dil=0;
                    for (int i = low.Length-1; i >= 0; i--)
                    {
                        k++;
                        if (!mask[i])
                            continue;
                        maskStep[i] = 0 == dil % 2;
                        dil = dil / 2;
                    }
                    for (int i = 0; i < low.Length; i++)
                    {

                        if (maskStep[i])
                            newString[c, i] = low[i];
                        else
                            newString[c, i] = UP[i];
                        Console.Write(newString[c, i]);
                    }
                    Console.WriteLine();
                }

            }
            while (run);
        }
    }
}
