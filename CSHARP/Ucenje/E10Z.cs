using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10Z
    {

        public static void Izvedi()
        {
            Console.Write("Unesi izraz: ");
            string izraz = Console.ReadLine();
            Console.WriteLine(izraz);
            if (izraz.Length%2 == 0)
            {
                Console.WriteLine("parno");
                bool palindorm = true;
                for (int i = 0; i < izraz.Length / 2; i++)
                {
                    if (izraz[i] != izraz[izraz.Length - 1 - i])
                    {
                        palindorm = false;

                        break;
                    }
                }
                Console.WriteLine(palindorm ? "DA" : "NE" );
                

            }
            else
            {
                Console.WriteLine("neparno");

            }




                
        }




    }
}
