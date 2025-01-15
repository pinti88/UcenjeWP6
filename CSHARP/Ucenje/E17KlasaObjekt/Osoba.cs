using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{
    
    // klasa je opisnik objekta -> NAUĆITI NAPAMET
    internal class Osoba
    {
        // klasa sadrzi svojsta (property)
        public int Sifra { get; set; } //OOP princip ućahurivanja
        public string? Ime { get; set; } //  ? oznaćava ako ime moze biti null
        public string? Prezime { get; set; }
        public Mjesto? Mjesto { get; set; }


        // klasa sadrzi metode (i ne moraju biti staticne)
        public string ImePrezime()
        {
            Console.WriteLine("Izvodjenje metode s objekta");
            return Ime + " " + Prezime;

        }
        public static void Izvedi()
        {
            Console.WriteLine("Izvodjenje staticne metode s klase");
        }


    }
}
