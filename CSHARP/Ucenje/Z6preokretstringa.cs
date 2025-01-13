using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Z6preokretstringa
    {
        public static void Izvedi()
        {

            string pojam = E12Metode.UcitajString("Unesite pojam za ispis unatrag: ");
           

            string unatrag = " ";

            for (int i = pojam.Length - 1; i >= 0; i--)
            {
               

                unatrag += pojam[i];
            }
            Console.WriteLine("Pojam  unatrag: " + unatrag);


        }


    }
}
