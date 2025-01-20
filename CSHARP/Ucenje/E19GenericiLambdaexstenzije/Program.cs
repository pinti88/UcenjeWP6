using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E17KlasaObjekt.edunova;

namespace Ucenje.E19GenericiLambdaexstenzije
{
    public class Program
    {
        public Program()
        {

            Console.WriteLine("E19");

            List<int> brojevi = new List<int>();


            brojevi.Add(7);
            brojevi.Add(2);
            // ne moze string jer mora int
            Console.WriteLine(brojevi[1]);

            var gradovi = new List<string>();

            gradovi.Add("Osijek");
            gradovi.Add("Zadar");

            foreach (string grad in gradovi)
            {
                Console.WriteLine(grad);
            }

            var smjerovi = new List<Smjer>();
            smjerovi.Add(new() { Naziv = "web programiranje" });
            smjerovi.Add(new() { Naziv = "Autolimar" });


            var s = new Smjer();
            s.Sifra = 1;
            s.Naziv = "Serviser";
            smjerovi.Add(s);
            Console.WriteLine(smjerovi[0].StariNaziv());

            var o = new Obrada<Smjer>();

            o.ObjekObrade = s;

            //var o1 = new Obrada<string>(); NE MOZE JER NASLJEDUJE ENTITET 

            //o1.ObjekObrade = "s";

            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            smjerovi.Sort();//metoda koja se solanja na Icomperable sucelje

            Console.WriteLine("******************************************************");

            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }
            Console.WriteLine("******************************************************");
            smjerovi.Reverse();
            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            // kreirajte listu datumna 
            // u listu stavite datum sog rodjenja i danasnji datum 

            var datumi = new List<DateTime>();
            datumi.Add(new DateTime(1998, 08, 08));
            datumi.Add(DateTime.Now);

            foreach (var d in datumi)
            {
                Console.WriteLine(d);
            }

            //Lambda izrazi 
            Console.WriteLine(KlasicnaMetoda(5, 5));

            var Zbroj = (int a, int b) => a + b;
            Console.WriteLine(Zbroj(5, 5));

            // komplekcinja sintaksa
            var Algoritam = (int x, int y) =>
            {
                var z = 0;
                z = ++x;
                y += z;
                return x + y + z;
            };

            Console.WriteLine(Algoritam(2, 3));

            var parni = (int i) => i % 2 == 0;
            Console.WriteLine(parni(7) ? "Parni" : "Neparni");

            // ekstenizije 
            string ime = "Ana";
            Console.WriteLine(ime.LastOrDefault());
            Console.WriteLine(smjerovi.LastOrDefault());

            // Koristenje vlasite ekstenzije 
            s.Ispisi();

            var p = new Polaznik() { Sifra = 7, Ime = "Pero" };
            p.Ispisi();

            // Zadnji krik ne OOP-a u OOP jeziku je definiranje obekta on the to fly

            var nesto = new
            {
                Ime = "Pero",
                Grad = "Osijek",
                Smjer = s
            };


         }

        private int KlasicnaMetoda(int a, int b)
        {
            return a + b;
        }
    }
}
