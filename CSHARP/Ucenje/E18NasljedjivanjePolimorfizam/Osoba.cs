using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedjivanjePolimorfizam
{
    public class Osoba : Entitet
    {
        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";

        public Osoba()
        {
        }

        public Osoba (string ime, string Prezime)
        {
            Ime = ime;
            Prezime = Prezime;

        }

    }
}
