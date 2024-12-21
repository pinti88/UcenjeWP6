using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Metode
    {
        public static void Izvedi()
        {
            // metode se sastoje od 2 dijela
            // 1. ijelo metode
            // 2. poziv metode
            Tip1();
            Tip1();


            Tip2(7);
            Tip2(5);

            Tip2(10, "Poziv druge varijante metode Tip2");


            int i = Tip3() + 1;
            Console.WriteLine(i);

            int[] niz = { 2, 5, 2, 1, 4, 1, 2, 4, 1, 2, 3 };
            Console.WriteLine(Tip4(niz));
            Tip4(niz);

        }

        // Tijelo metode
        // tip 1 Ne prima parametre, ne vraca vrijednosti
        static void Tip1(/*ovdje dodju parametri ili ne*/)
        {
            Console.WriteLine("Ispis iz 1. tipa metodee");
            Console.WriteLine("***********");
            Console.WriteLine("Kraj ispisa iz 1. metode");

        }
        // tip 2 prima parametre ali ne vraca vrijednosti
        private static void Tip2(int x) // x je parametar tipa int
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }



        }

        // potpis metode 
        // naziv + lista parametara
        // metod overloading
        private static void Tip2(int x, string naslov)
        {
            Console.WriteLine(naslov);
            Tip2(x);


        }
        // tip 3 ne prima parametre ali vraca vrijednost
        private static int Tip3()
        {
            return int.MaxValue;
        }

        // tip 4 prima parametre i vraca vrijednost
        /// <summary>
        /// metoda ce za primljeni niz cijelih brojeva vratiti sumu 
        /// </summary>
        /// <param name="niz"></param>
        /// <returns></returns>
        private static int Tip4(int[] niz)
        {
            int sum = 0;
            foreach (int i in niz)
            {
                sum += i;
            }
            return sum;
        }



        // Nama bitne metode
        //write once use everywhere

        public static int UcitajCijeliBroj(string poruka)
        {

            while (true)
            {
                Console.WriteLine(poruka);
                try
                {
                    return int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Pronlem kod ucitanja broja");

                }
            }
        }
               public static int UcitajCijeliBroj(string poruka, int min, int max)
        {
            int i;
            while (true)
            {
                Console.WriteLine(poruka);
                try
                {
                    i=int.Parse(Console.ReadLine());
                    if (i < min || i > max)
                    {
                        Console.WriteLine("Broj nije u danom rasponu {0} - {1} ", min, max);
                        continue;
                    }
                    return i;
                
                
                }

                catch
                {
                    Console.WriteLine("Problem kod ucitanja broja");

                }
            }

        }
        public static string UcitajString(string poruka)
        {
            string s = "";
            while (true)
            {
                Console.WriteLine(poruka);
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    Console.WriteLine("obavezan unos");
                    continue;
                }
                return s;
            }
        }
        
        
        public static bool UcitajBool(string poruka, string uvijetZaTrue)
        {
            Console.Write(poruka);
            return Console.ReadLine().Trim().ToUpper() == uvijetZaTrue.ToUpper();

        }

    }
}
