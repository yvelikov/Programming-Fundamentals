using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Cypher_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string textToPrint = string.Empty;
            string lastString = string.Empty;
            string text = string.Empty;
            bool toSpin = false;

            for (int i = 0; i < n; i++)
            {
                lastString = text;
                text = Console.ReadLine();

                if (text == lastString)
                {
                    textToPrint = string.Empty;
                    if (text == "spin")
                    {
                        i--;
                    }
                    continue;
                }
                if (text == "spin")
                {
                    i--;
                    toSpin = !toSpin;
                    continue;
                }
                

                if (toSpin)
                {
                    textToPrint = text + textToPrint;
                }
                else textToPrint += text;






            }
            Console.WriteLine(textToPrint);

        }
  
      

    }
}
