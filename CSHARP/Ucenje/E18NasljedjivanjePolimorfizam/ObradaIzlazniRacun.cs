﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedjivanjePolimorfizam
{
    public class ObradaIzlazniRacun : Obrada
    {
        public override void Procesuiraj()
        {
            Console.WriteLine("Obrađujem izlazni račun");
            Console.WriteLine("Posalji ga");
        }

    }
}
