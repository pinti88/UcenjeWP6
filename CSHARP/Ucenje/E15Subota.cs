using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E15Subota
    { 
        public static void Izvedi()
        {

            PrimjerTryCatch();

        }
        private static void PrimjerTryCatch()
        {
            try
            {
                int.Parse("Osijek");


            }
            catch 
            {
                Console.WriteLine(" zao nam je zbog greske");

                
            }
            //osigurajte unos logicke vrijednosti
            bool vrijednost = false;    
            
            
                Console.WriteLine("Dali si zaposlen/a ? (upisi DA ili bilo sto za ne) ");
                if (Console.ReadLine().Trim().ToUpper() == "DA")
                {
                    vrijednost = true;
                }

             Console.WriteLine(vrijednost);

            Console.WriteLine(E12Metode.UcitajBool("Dali si zaposlen/a (upisi DA ili bilo sto za ne)", "DA"));
            Console.WriteLine(E12Metode.UcitajBool("Jutros sam pojeo tri sendvica (Istina/Laz)", "Istina"));



        }
    
  
    
    
    
    }
} 
        
   
           




        
   

