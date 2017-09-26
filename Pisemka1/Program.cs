using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisemka1
{
    class Program
    {
        public static bool IsNumberOrNot(char znak)
        {           
            double cislo = Char.GetNumericValue(znak);

            if (cislo >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }          
        }
        static void Main(string[] args)
        {
            //List<double> output = new List<double>(); Jsem si neuvědomil, že pak ty čísla nemusím vypisovat XD
            bool lastCheck = false; //True = poslední bylo číslo, False = poslední nebylo číslo            
            double currentNumber = 0;            
            int numCount = 0;
            while (true)
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (String.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Musíš něco zadat, jinak z toho nemůžu zjistit, kolik je tam čísel.");
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                           if (IsNumberOrNot(input[i]))
                            {
                                lastCheck = true;
                                currentNumber = currentNumber * 10 + Char.GetNumericValue(input[i]);
                            }
                            else
                            {
                                if (lastCheck && !String.IsNullOrEmpty(currentNumber.ToString()))
                                {                                    
                                    lastCheck = false;
                                    currentNumber = 0;
                                    numCount++;
                                }
                            }
                        }
                        if (Char.GetNumericValue(input[input.Length - 1]) >= 0)
                        {
                            numCount++;
                        }
                        Console.WriteLine("V textu je " + numCount + " čísel");
                        break;
                    }
                }
                //end of second while
                currentNumber = 0;
                numCount = 0;
                lastCheck = false;
            }
            //end of first while
        }
    }
}
