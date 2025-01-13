using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Z9sortiranjeniza
    {
        public static void Izvedi()
        {

            Console.WriteLine("Unos i sortiranje niza cijelih brojeva");

            Console.Write("Unesite broj elemenata niza: ");
            int brojElemenata;
            while (!int.TryParse(Console.ReadLine(), out brojElemenata) || brojElemenata <= 0)
            {
                Console.WriteLine("Pogrešan unos. Molimo unesite prirodan broj veći od nule.");
                Console.Write("Unesite broj elemenata niza: ");
            }

            int[] niz = new int[brojElemenata];

            for (int i = 0; i < brojElemenata; i++)
            {
                Console.Write($"Unesite vrijednost za element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out niz[i]))
                {
                    Console.WriteLine("Pogrešan unos. Molimo unesite cijeli broj.");
                    Console.Write($"Unesite vrijednost za element {i + 1}: ");
                }
            }

            Array.Sort(niz);

            Console.WriteLine("Sortirani niz uzlazno:");
            foreach (int broj in niz)
            {
                Console.Write(broj + " ");
            }
            Console.WriteLine();
        }

    }
}
