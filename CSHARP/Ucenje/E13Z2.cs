using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z2
    {

        public static void Izvedi()
        {
            zad2();


        }
        private static void zad1()
        {
            Console.WriteLine("Dobro dosli u prvi zadatak");
            string ime;
            while (true)
            {
                ime = E12Metode.UcitajString("Unesi ime osobe (NE za kraj):  ");
                if (ime.ToUpper() == "NE")
                {
                    Console.WriteLine("Hvala na koristenju programa 1. Zadatak");
                    break;

                }


               
                Console.WriteLine(ime.Length);
            }
        }

        //Zad 2 program unosi ime osobe i ime i prezime osobe. program ispisuje prezime i ime 

        private static void zad2()
        {
            string ime;
            string prezime;
            while (true)
            {
                ime = E12Metode.UcitajString("unesi ime : ");
                prezime = E12Metode.UcitajString("unesi prezime: ");
                Console.WriteLine("{0} {1}", prezime, ime);
                if(E12Metode.UcitajString("DA za jos: ").ToUpper() != "DA")
                {
                    break;
                }
            }

        }









    }
}




