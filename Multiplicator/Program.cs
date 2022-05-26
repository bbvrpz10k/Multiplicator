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
            while(true)
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
                    if (!mask[i])
                        CountLetter++;
                }
                int CountNew = ((int)Math.Pow(2, CountLetter)) + 1;
                string[] newString = new string[CountNew];
                for (int c = 0; c < CountNew; c++)
                {
                    int dil=c;
                    for (int i = low.Length-1; i >= 0; i--)
                    {
                        if (mask[i])
                            continue;
                        maskStep[i] = 0 == dil % 2;
                        dil = dil / 2;
                    }
                    char[] newstring = new char[low.Length];
                    for (int i = 0; i < low.Length; i++)
                    {

                        if (maskStep[i])
                            newstring[i] = low[i];
                        else
                            newstring[i] = UP[i];
                        newString[c]= newstring.ToString();
                    }
                    Console.WriteLine(newstring);
                }

            }
        }
    }
}
