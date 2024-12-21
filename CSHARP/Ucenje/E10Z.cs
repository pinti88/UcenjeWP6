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
            string s = "RužanEdoOdeNaŽur";
            Console.WriteLine(string.Join(':',s.ToCharArray()));

            Console.WriteLine("palindrom");

            string izraz = E12Metode.UcitajString("Unesi izraz za provjeru palindroma: ");

            bool palindrom = true;
            izraz = izraz.ToUpper();
            
            //ispisi prvo slovo
            Console.WriteLine(izraz[0]);
            
            //ispisati zdanje slovo
            Console.WriteLine(izraz[izraz.Length - 1]);

            // ispisi drugo slovo
            Console.WriteLine(izraz[1]);
            
            //ispisi predzadnje slovo
            Console.WriteLine(izraz[izraz.Length - 1 - 1]);
            
            
            
            for (int i = 0; i < izraz.Length / 2; i++)

            {
                if (izraz[i] == izraz[izraz.Length-1 - i])
                {
                    palindrom = false;
                    break;
                }
            }
            Console.WriteLine("Izraz {0} {1} palindorm,", izraz, palindrom  ? "JE" : "NIJE" );






        }






    }
}
