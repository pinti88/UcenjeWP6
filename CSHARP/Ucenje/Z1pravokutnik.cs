using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Z1pravokutnik
    {
        public static void Izvedi()
        {

            int duzina = E12Metode.UcitajCijeliBroj("Unesi dužinu pravokutnika: ");

            int sirina = E12Metode.UcitajCijeliBroj("Unesi širinu pravokutnika: ");
            
            int povrsina = duzina * sirina;

            Console.WriteLine("Površina pravokutnika je: ", povrsina);
            
            Console.WriteLine(povrsina);


        }
    }
}
