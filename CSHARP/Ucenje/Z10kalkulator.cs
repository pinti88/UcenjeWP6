using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Z10kalkulator
    {

        public static void Izvedi()
        {

            Console.WriteLine("Kalkulator: Unesite dva broja i odaberite operaciju (+, -, *, /)");

            Console.Write("Unesite prvi broj: ");
            double broj1;
            while (!double.TryParse(Console.ReadLine(), out broj1))
            {
                Console.WriteLine("Pogrešan unos. Molimo unesite broj.");
                Console.Write("Unesite prvi broj: ");
            }

            Console.Write("Unesite drugi broj: ");
            double broj2;
            while (!double.TryParse(Console.ReadLine(), out broj2))
            {
                Console.WriteLine("Pogrešan unos. Molimo unesite broj.");
                Console.Write("Unesite drugi broj: ");
            }

            Console.Write("Unesite operaciju (+, -, *, /): ");
            char operacija;
            while (!char.TryParse(Console.ReadLine(), out operacija) ||
                   (operacija != '+' && operacija != '-' && operacija != '*' && operacija != '/'))
            {
                Console.WriteLine("Pogrešan unos. Molimo unesite jednu od operacija: +, -, *, /.");
                Console.Write("Unesite operaciju (+, -, *, /): ");
            }

            double rezultat;
            switch (operacija)
            {
                case '+':
                    rezultat = broj1 + broj2;
                    Console.WriteLine($"Rezultat: {broj1} + {broj2} = {rezultat}");
                    break;

                case '-':
                    rezultat = broj1 - broj2;
                    Console.WriteLine($"Rezultat: {broj1} - {broj2} = {rezultat}");
                    break;

                case '*':
                    rezultat = broj1 * broj2;
                    Console.WriteLine($"Rezultat: {broj1} * {broj2} = {rezultat}");
                    break;

                case '/':
                    if (broj2 != 0)
                    {
                        rezultat = broj1 / broj2;
                        Console.WriteLine($"Rezultat: {broj1} / {broj2} = {rezultat}");
                    }
                    else
                    {
                        Console.WriteLine("Dijeljenje s nulom nije dozvoljeno.");
                    }
                    break;

                default:
                    Console.WriteLine("Nepoznata operacija.");
                    break;
            }

            Console.WriteLine("Hvala što ste koristili kalkulator!");
        }
    }
}
