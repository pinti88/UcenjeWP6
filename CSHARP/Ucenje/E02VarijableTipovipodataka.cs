using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E02VarijableTipovipodataka
    {


        public static void Izvedi()
        {

            //Console.WriteLine("hello E02");
            
            
            //deklaracija varijable 

            int i; //i je increment

            Console.Write("upši broj: ");
            //dodjeljivanje vrjednosti
            //dodjeljivanje vrjijednosti

            //i = console.ReadLine(); ovo ne raditi jer je desno string a lijevo int
            i = int.Parse(Console.ReadLine());


            //koritenje vrjednosti
            Console.WriteLine("upisali ste {0}", i);


            // bit - logicka vrijednost 

            bool logickaVrijednost;

            Console.Write("unesi True ili False: ");

            logickaVrijednost = bool.Parse(Console.ReadLine());
            Console.WriteLine("unijeli ste {0}", logickaVrijednost);

            //float-decimalni broj

            Console.Write("unesi broj (, za decimalni dio): ");
            Console.WriteLine(float.Parse(Console.ReadLine()));

            float broj = 3.14F; // f zato sto je to float 

            Console.WriteLine("unesi ime: ");
           
            string ime = Console.ReadLine();
            
            Console.WriteLine("unio sam \n{0}\n{1}\n{2}\n{3}",
                i,logickaVrijednost, broj, ime);


           



        }


    }
}
