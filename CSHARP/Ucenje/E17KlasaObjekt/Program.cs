using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E17KlasaObjekt.edunova;

namespace Ucenje.E17KlasaObjekt
{
    public class Program
    {

        // 5. vrsta metode (posebna) konstruktor
        // konstruktor mora imati isti naziv kao i klasa a lista parametara moze biti razlicita 
        public Program()
        {
            // objek je instanca(pojavnost) klase 
            // Osoba je ime klase (primjetiti veliko pocetno slovo)
            // osoba je ime objekta 

            Osoba osoba = new Osoba();


            osoba.Sifra = 1;

            osoba.Ime = "Pero";   //E12Metode.UcitajString
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.Ime);

            osoba = new Osoba() { Sifra = 2, Ime = "Karlo", Prezime = "Lik" };

            Console.WriteLine("{0} {1}", osoba.Ime, osoba.Prezime);
            Console.WriteLine(osoba.ImePrezime());

            Osoba.Izvedi();

            Mjesto mjesto = new Mjesto() { Naziv = "Osijek", PostanskiBroj = "31000" };

            //osoba.Mjesto = mjesto;


            if (osoba.Mjesto != null)
            {
                Console.WriteLine(osoba.Mjesto.Naziv);
            }
            Console.WriteLine(osoba.Mjesto?.Naziv);

            osoba.Mjesto = new Mjesto() { Naziv = "Osijek" };
            Console.WriteLine(osoba.Mjesto.Zupanija?.Zupan ?? "Prazno"); //nakon ?? ide vrjednost koja se koristi ako je svojstvo null


            Smjer smjer = new Smjer() { Naziv = "Web Programiranje" };
            Grupa grupa = new() { Naziv = "WP6", Smjer = smjer };
            Polaznik[] polazniciNiz = new Polaznik[2];
            polazniciNiz[0] = new Polaznik() { Ime = "Pero" };
            polazniciNiz[1] = new Polaznik() { Ime = "Marija" };

            grupa.Polaznici = polazniciNiz;

            Console.WriteLine(grupa.Naziv);
            Console.WriteLine(grupa.Smjer.Naziv);
            foreach(Polaznik p in grupa.Polaznici)
            {
                Console.WriteLine("{0} {1}", p.Ime, p.Prezime);
            }
            Console.WriteLine("****************************************************");

            grupa.DetaljiGrupe();

        }



    }

}
