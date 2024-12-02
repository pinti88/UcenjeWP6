using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    internal class E01ulazizlaz
    {


        public static void izvedi() 
        {
            
            
            
            //ovo je izlaz
            Console.Write("unesi svoje ime: ");
            
            
            //ulaz podataka u program 
            string Ime = Console.ReadLine();    
            Console.WriteLine("unjeli ste" + Ime);

            //formatirani nacin ispisa 
            Console.WriteLine( "unjeli ste {0}. bravo!", Ime);

        }
       



       
        }
}
