using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedjivanjePolimorfizam
{
    public class Program
    {
        public Program(string s)
        {
            Console.WriteLine("E18");
            var smjer = new Smjer() { Sifra = 1, Naziv = "web programiranje" };

            Console.WriteLine(smjer);

            var osoba = new Osoba() { Sifra = 1, Ime = "Pero", Prezime = "Perić" };

            osoba = new Osoba("Marija", "Zimska");


            Console.WriteLine(osoba);

            string s1 = "AA";

            Console.WriteLine(s1.GetHashCode());

            s1 = "BB";
            Console.WriteLine(s1.GetHashCode());

            // dobra praksa je kirstiti string buider

            var sb = new StringBuilder();

            sb.Append("AA");
            Console.WriteLine(sb.GetHashCode());

            sb.Clear().Append("BB");

            Console.WriteLine(sb.GetHashCode());



            Smjer smjer1 = new Smjer() { Naziv = "web programiranje" };
            Smjer smjer2 = new Smjer() { Naziv = "web programiranje" };

            Console.WriteLine(smjer1.GetHashCode());
            Console.WriteLine(smjer2.GetHashCode());

            Console.WriteLine(smjer.Equals(smjer2));



            //var e = new Entitet();
            //e.Sifra = 1;
            var e = new EntitetImpl() { Sifra = 1 };

            // jos nismo na polimorfizmu

            Obrada[] obrade = new Obrada[2];

            obrade[0] = new ObradaUlazniRacun();
            obrade[1] = new ObradaIzlazniRacun();


            //polimorfizam

            foreach (Obrada o in obrade)
            {
                o.Procesuiraj();
            }




        }


    }
}
