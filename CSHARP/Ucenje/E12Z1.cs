using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    //program za 2 unesena broja ispisuje njhov zbroj
    internal class E12Z1
    {

        public static void Izvedi()
        {
            int pb = E12Metode.UcitajCijeliBroj("unesi prvi broj");
            int db = E12Metode.UcitajCijeliBroj("unesi drugi broj");


            Console.WriteLine("{0}+{1}= {2}",pb,db,pb+db);



        }

    }
}
