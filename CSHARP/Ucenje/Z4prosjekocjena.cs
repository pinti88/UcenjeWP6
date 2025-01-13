using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Z4prosjekocjena
    {
        public static void Izvedi()
        {

            
            int brojOcjena = E12Metode.UcitajCijeliBroj("Unesi broj ocjena za izračun: ");
            int[] ocjene = new int[brojOcjena];

           
            for (int i = 0; i < ocjene.Length; i++)
            {
                Console.Write("Ocjena " + (i + 1) + " :");
                ocjene[i] = int.Parse(Console.ReadLine());

            }


            int suma = 0;

            for (int i = 0; i < ocjene.Length; i++)
            {

                suma += ocjene[i];

            }

         
            float prosjek = (float)suma / brojOcjena;


            Console.WriteLine("Prosjek svih ocjena je: " + prosjek);


        }

    }
}
