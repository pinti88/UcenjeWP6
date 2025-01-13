using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Z8pretvorbatemperature
    {

        public static void Izvedi()
        {
            Console.WriteLine("Dobrodošli u pretvorbu temperature!");
            Console.WriteLine("Odaberite opciju:");
            Console.WriteLine("1. Pretvorba iz Celzijusa u Fahrenheit");
            Console.WriteLine("2. Pretvorba iz Fahrenheita u Celzijus");

            int izbor;
            while (true)
            {
                Console.Write("Unesite broj opcije (1 ili 2): ");
                if (int.TryParse(Console.ReadLine(), out izbor) && (izbor == 1 || izbor == 2))
                {
                    break;
                }
                Console.WriteLine("Pogrešan unos. Pokušajte ponovno.");
            }

            Console.Write("Unesite temperaturu: ");
            double temperatura;
            while (!double.TryParse(Console.ReadLine(), out temperatura))
            {
                Console.WriteLine("Pogrešan unos. Molimo unesite ispravnu temperaturu.");
                Console.Write("Unesite temperaturu: ");
            }

            if (izbor == 1)
            {
                double fahrenheit = temperatura * 9 / 5 + 32;
                Console.WriteLine($"{temperatura} °C je jednako {fahrenheit:F2} °F.");
            }
            else
            {
                double celzijus = (temperatura - 32) * 5 / 9;
                Console.WriteLine($"{temperatura} °F je jednako {celzijus:F2} °C.");
            }

            Console.WriteLine("Hvala što ste koristili pretvorbu temperature!");

        }

    }
}
