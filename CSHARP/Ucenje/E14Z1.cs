using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Z1
    {
        public static void Izvedi()
        {
            Console.WriteLine("Dobrodosli u vjezbanje petkom");
            Izbornik();
            Console.WriteLine("Hvala na koristenju dovidjenja");


        }
        public static void Izbornik()
        {

            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
            Console.WriteLine("1. parnost broja ");
            Console.WriteLine("2. Tablica mnozenja");
            Console.WriteLine("0. Izlaz iz programa");
            Odabiropcijeizbornika();


        }

        private static void Odabiropcijeizbornika()
        {
            switch (E12Metode.UcitajCijeliBroj("Odaberi stavke izbornika", 0, 2))
            { case 0:
                    break;
                case 1:
                    ParnostBroja();
                    Izbornik();
                    break;
                case 2:
                    TablicaMnozenja();
                    Izbornik();
                    break;



            }
        }

        private static void TablicaMnozenja()
        {
            NaslovPrograma("Program koji dane brojev redova i stupaca generira tablicu mnozenja");

            


        }

        private static void ParnostBroja()
        {
            NaslovPrograma("Program koji provjerava dali je uneseni broj paran ili ne"); 
            int broj = E12Metode.UcitajCijeliBroj("unesi cijeli broj: ");
            if (broj % 2 == 0)
            {
                Console.WriteLine("uneseni broj {0} je PARAN", broj);
            }
            else
            {
                Console.WriteLine("Uneseni broj {0} je NEPARAN", broj);
            }

        }
        private static void NaslovPrograma(string naslov)
        {

            Zvjezdice(naslov.Length);
            Console.WriteLine(naslov);
            Zvjezdice(naslov.Length);
        }
        private static void Zvjezdice(int komada)
        {
            for (int i = 0; i < komada; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
