using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Program od korisnika traži unos dva cijela broja
    // Program ispisuje manji

    // isti zadatak ali za tri unesena broja ispisati najmanji

    internal class E04Z3
    {
        public static void Izvedi()
        {
            // Console.WriteLine("e04");

            Console.WriteLine("Unesite prvi cijeli broj: ");
            int prvibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi cijeli broj: ");
            int drugibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite treći cijeli broj: ");
            int trecibroj = int.Parse(Console.ReadLine());

            if (prvibroj < drugibroj && prvibroj < trecibroj)
            {
                Console.WriteLine("Manji broj je:" + prvibroj);
            }
            else if (drugibroj < prvibroj && drugibroj < trecibroj) 
            {
                Console.WriteLine("Manji broj je: " + drugibroj);
            }
            else 
            {
                Console.WriteLine("Manji broj je : " + trecibroj);
            
            
            }




            

        }

    }
}
