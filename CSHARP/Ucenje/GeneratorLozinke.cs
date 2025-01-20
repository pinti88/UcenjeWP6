using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class GeneratorLozinke
    {
        public static void Izvedi()
        {
            Console.WriteLine("Generator Lozinki");

            // Traženje dužine lozinke
            Console.Write("Unesite dužinu lozinke: ");
            int duljinaLozinke;
            while (!int.TryParse(Console.ReadLine(), out duljinaLozinke) || duljinaLozinke <= 0)
            {
                Console.WriteLine("Molimo unesite pozitivni cijeli broj.");
                Console.Write("Unesite dužinu lozinke: ");
            }

            // Postavke uključivanja raznih znakova
            bool velikaSlova = UpitDaNe("Uključiti velika slova (A-Z)?");
            bool malaSlova = UpitDaNe("Uključiti mala slova (a-z)?");
            bool brojevi = UpitDaNe("Uključiti brojeve (0-9)?");
            bool interpunkcija = UpitDaNe("Uključiti interpunkcijske znakove (!@#$...)?");

            // Pravila za početak i završetak lozinke
            bool pocinjeBrojem = brojevi && UpitDaNe("Lozinka počinje brojem?");
            bool pocinjeInterpunkcijom = interpunkcija && UpitDaNe("Lozinka počinje interpunkcijskim znakom?");
            bool zavrsavaBrojem = brojevi && UpitDaNe("Lozinka završava brojem?");
            bool zavrsavaInterpunkcijom = interpunkcija && UpitDaNe("Lozinka završava interpunkcijskim znakom?");

            // Pravilo za ponavljanje znakova
            bool bezPonavljanja = UpitDaNe("Lozinka nema ponavljajuće znakove?");

            // Broj lozinki za generiranje
            Console.Write("Koliko lozinki želite generirati? ");
            int brojLozinki;
            while (!int.TryParse(Console.ReadLine(), out brojLozinki) || brojLozinki <= 0)
            {
                Console.WriteLine("Molimo unesite pozitivan cijeli broj.");
                Console.Write("Koliko lozinki želite generirati? ");
            }

            // Skupovi znakova
            string velikaSlovaSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string malaSlovaSet = "abcdefghijklmnopqrstuvwxyz";
            string brojeviSet = "0123456789";
            string interpunkcijaSet = "!@#$%^&*()-_=+[]{}|;:'<>,.?/";

            // Gradimo bazen znakova prema postavkama
            StringBuilder bazen = new StringBuilder();
            if (velikaSlova) bazen.Append(velikaSlovaSet);
            if (malaSlova) bazen.Append(malaSlovaSet);
            if (brojevi) bazen.Append(brojeviSet);
            if (interpunkcija) bazen.Append(interpunkcijaSet);

            if (bazen.Length == 0)
            {
                Console.WriteLine("Morate odabrati barem jednu vrstu znakova za generiranje lozinki.");
                return;
            }

            Random random = new Random();

            for (int i = 0; i < brojLozinki; i++)
            {
                StringBuilder lozinka = new StringBuilder();

                // Dodavanje početnih znakova prema pravilima
                if (pocinjeBrojem)
                    lozinka.Append(brojeviSet[random.Next(brojeviSet.Length)]);
                else if (pocinjeInterpunkcijom)
                    lozinka.Append(interpunkcijaSet[random.Next(interpunkcijaSet.Length)]);

                // Generiranje srednjih znakova
                while (lozinka.Length < duljinaLozinke - (zavrsavaBrojem || zavrsavaInterpunkcijom ? 1 : 0))
                {
                    char noviZnak = bazen[random.Next(bazen.Length)];
                    if (bezPonavljanja && lozinka.ToString().Contains(noviZnak))
                        continue;
                    lozinka.Append(noviZnak);
                }

                // Dodavanje završnih znakova prema pravilima
                if (zavrsavaBrojem)
                    lozinka.Append(brojeviSet[random.Next(brojeviSet.Length)]);
                else if (zavrsavaInterpunkcijom)
                    lozinka.Append(interpunkcijaSet[random.Next(interpunkcijaSet.Length)]);

                Console.WriteLine($"Generirana lozinka {i + 1}: {lozinka}");

            }
            static bool UpitDaNe(string pitanje)
            {
                Console.Write(pitanje + " (da/ne): ");
                string odgovor = Console.ReadLine().ToLower();
                while (odgovor != "da" && odgovor != "ne")
                {
                    Console.WriteLine("Molimo odgovorite s 'da' ili 'ne'.");
                    Console.Write(pitanje + " (da/ne): ");
                    odgovor = Console.ReadLine().ToLower();
                }
                return odgovor == "da";


            }
        }

    }
}