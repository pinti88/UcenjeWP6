using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Z5fibonaccijevniz
    {

        public static void Izvedi()
        {
            Console.WriteLine("Fibonaccijev niz");

            int unosKorisnika = E12Metode.UcitajCijeliBroj("Unesi broj do kojeg će ići fibonaccijev niz: ");
            string broj = unosKorisnika.ToString();

            foreach (char c in broj.ToCharArray())
            {

                Console.WriteLine(unosKorisnika);

            }
            
            int prviBroj = 0, drugiBroj = 1;

            Console.WriteLine("Fibonaccijev niz do njegovog {0} broja: ", unosKorisnika);
            for (int i = 1; i <= unosKorisnika; i++)
            {
                Console.Write(prviBroj + " "); 

                
                int sljedeci = prviBroj + drugiBroj;
                prviBroj = drugiBroj;
                drugiBroj = sljedeci;


            }
            Console.WriteLine();

        }


    }
}
