using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Rekurzija
    {
        public static void Izvedi()
        {
            Console.WriteLine(Zbroj(100));
        }   
        //Izvedi(); // ovdje dobijemo stack overflow

            private static int Zbroj(int broj)
        {
            
            if (broj == 1)
            {
                return 1;
            }


            return broj + Zbroj(broj - 1);
        }
        





        
        
        
        
        
            

        



    }           
}
