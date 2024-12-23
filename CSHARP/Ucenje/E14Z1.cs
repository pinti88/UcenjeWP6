using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Z1
    {// za dani broj izmedju 20 i 50 ispisi koja mu je vrijednost jedinice 
        //34 -> 4
        //21-> 1
        public static void Izvedi()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dobrodosli u vjezbanje petkom");
            Console.ResetColor();

            Izbornik();
            Console.WriteLine("Hvala na koristenju dovidjenja");


        }






        public static void Izbornik()
        {
            string[] programi =
            {
                "Parnost boja",
                "Tablica mnozenja",
                "Vrijednost jedinica",
                "Broj znakova naziva mjesta",
                "Zbroj znamenki broja",
                "Prebrojavanje broja znakova"
            };


            Console.WriteLine();
            Console.WriteLine("IZBORNIK");

            for (int i = 0; i < programi.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, programi[i]);
            }
            Console.WriteLine("0. Izlaz iz programa ");
            Odabiropcijeizbornika(programi.Length);


            Console.WriteLine("0. Izlaz iz programa");
            Odabiropcijeizbornika(programi.Length);


        }

        private static void Odabiropcijeizbornika(int brojprograma)
        {
            switch (E12Metode.UcitajCijeliBroj("Odaberi stavke izbornika", 0, brojprograma))
            {
                case 0:
                    break;
                case 1:
                    ParnostBroja();
                    Izbornik();
                    break;
                case 2:
                    TablicaMnozenja();
                    Izbornik();
                    break;
                case 3:
                    Vrijednostjedinica();
                    Izbornik();
                    break;
                case 4:
                    Brojznakovanazivamjesta();
                    Izbornik();
                    break;
                case 5:
                    Zbrojznamenkibroja();
                    Izbornik();
                    break;
                case 6:
                    Prebrojavanjeznamenkibroja();
                    Izbornik();
                    break;







            }
        }

        private static void Prebrojavanjeznamenkibroja()
        {
            NaslovPrograma("Prezbrojavanje znakova u izrazu");

            string izraz = E12Metode.UcitajString("Unesi izraz: ").ToLower();

            //Danas pada snijeg
            int[] niz = new int[izraz.Length];
            bool[] ispisi = new bool[izraz.Length];  // njegove sve vrijednosti su false 
            int b;
            for (int i = 0; i < izraz.Length; i++)
            {
                b = 0;
                foreach (char c2 in izraz)
                {
                    if (izraz[i] == c2)
                    {
                        b++;
                    }
                }
                niz[i] = b;
                if (b > 1)
                {
                    for (int j = 0; j < izraz.Length; j++)
                    {
                        if (izraz[i] == izraz[j]) ;
                        {
                            ispisi[j] = true;
                            break;
                        }


                    }
                }
                else
                {
                    ispisi[i] = true;
                }
            }
            Console.WriteLine(string.Join(",", ispisi));
            for (int i = 0; i < izraz.Length; i++)
            {
                if (ispisi[i] && izraz[i] != ' ')
                {
                    Console.Write("{0} ({1})", izraz[i], niz[i]);
                }
            }
            Console.WriteLine();




        }

        private static void Zbrojznamenkibroja()
        {
            string broj = E12Metode.UcitajString("Unesi cijeli broj: ");
            int manjiOd = E12Metode.UcitajCijeliBroj("Zbroj mora biti manji od: ");


            if (!ProvjerabrojaUredu(broj))
            {
                Console.WriteLine("Nije dobar broj!!!");
                return;
            }
            //mi smo sada sigurni da u nasem stringu postoje samo znakovi koji su brojevi

            int rez = int.MaxValue;
            while (rez > manjiOd)
            {
                rez = 0;     //(int)BigInteger.Zero;
                foreach (char c in broj)
                {
                    rez += int.Parse(c.ToString());
                }
                Console.WriteLine(rez);
                broj = rez.ToString();

            }

            Console.WriteLine(rez);

        }

        private static bool ProvjerabrojaUredu(string broj)
        {


            foreach (char z in broj)
            {
                try
                {
                    int.Parse(z.ToString());
                }
                catch
                {
                    return false;


                }
            }

            return true;


        }

        private static void Brojznakovanazivamjesta()
        {
            NaslovPrograma("Za uneseni naziv mijesta is");
            Console.WriteLine(E12Metode.UcitajString("Unesi ime grada").Length);


        }

        private static void TablicaMnozenja()
        {
            NaslovPrograma("Program koji dane brojev redova i stupaca generira tablicu mnozenja");
            int redaka = E12Metode.UcitajCijeliBroj("Unesi broj redaka ", 2, 10);
            int stupaca = E12Metode.UcitajCijeliBroj("Unesi broj stupaca ", 2, 10);


            for (int i = 1; i <= redaka; i++)
            {
                for (int j = 1; j <= stupaca; j++)
                {
                    Console.Write("{0,4}", i * j);
                }
                Console.WriteLine();

            }



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

            NaglasiNaslov(naslov.Length);
            Console.WriteLine(naslov);
            NaglasiNaslov(naslov.Length);
        }
        private static void NaglasiNaslov(int komada)
        {

            for (int i = 0; i < komada; i++)

            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        private static void Vrijednostjedinica()
        {
            NaslovPrograma("Vrijednost jedinica");
            int broj = E12Metode.UcitajCijeliBroj("Unesi broj izmedju 20 i 50: ", 20, 50);
            Console.WriteLine(broj % 10);






        }

    }
}
