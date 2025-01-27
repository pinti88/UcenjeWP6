using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class LJubavniKalkulator
    {

        public static void Izvedi()
        {
            Console.WriteLine("Dobrodošli u Ljubavni Kalkulator!");

            while (true)
            {
                Console.Write("Unesite ime prve osobe: ");
                string ime1 = ValidirajUnos(Console.ReadLine());

                Console.Write("Unesite ime druge osobe: ");
                string ime2 = ValidirajUnos(Console.ReadLine());

                string spojenaImena = ime1.ToLower() + ime2.ToLower();

                int[] vrijednosti = PretvoriUASCII(spojenaImena);

                int ljubavniPostotak = IzracunajPostotak(vrijednosti);

                Console.WriteLine($"Kompatibilnost između {ime1} i {ime2} je: {ljubavniPostotak}%");

                Console.Write("Želite li ponovno izračunati? (da/ne): ");
                if (Console.ReadLine().Trim().ToLower() != "da")
                    break;
            }
        }

        static string ValidirajUnos(string unos)
        {
            while (!SamoSlova(unos))
            {
                Console.Write("Neispravan unos. Molimo unesite samo slova: ");
                unos = Console.ReadLine();
            }
            return unos;
        }

        static bool SamoSlova(string unos)
        {
            foreach (char c in unos)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        static int[] PretvoriUASCII(string tekst)
        {
            int[] vrijednosti = new int[tekst.Length];
            for (int i = 0; i < tekst.Length; i++)
            {
                vrijednosti[i] = (int)tekst[i] % 10; 
            }
            return vrijednosti;
        }

        static int IzracunajPostotak(int[] vrijednosti)
    {
        
        if (vrijednosti.Length == 2)
        {
            return vrijednosti[0] * 10 + vrijednosti[1];
        }

        
        int[] noviNiz = new int[(vrijednosti.Length + 1) / 2];

        for (int i = 0; i < vrijednosti.Length / 2; i++)
        {
            noviNiz[i] = (vrijednosti[i * 2] + vrijednosti[i * 2 + 1]) % 10;
        }

        
        if (vrijednosti.Length % 2 != 0)
        {
            noviNiz[noviNiz.Length - 1] = vrijednosti[vrijednosti.Length - 1];
        }

        
        return IzracunajPostotak(noviNiz);
    }
    }
}
