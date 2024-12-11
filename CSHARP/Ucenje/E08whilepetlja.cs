using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ucenje
{
    internal class E08whilepetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E08");
            int brojDo = 10;
            for (int t = 0; t < brojDo; t++)
            {
                Console.WriteLine(t);
            }  

            while (true)
            {
                Console.WriteLine("Osijek");
                break;
                
                   

            }

            int broj = 0, i = 2 ;

            while (broj <10 && i == 2 )
            {   
                Console.WriteLine(++broj);
            }

            broj = 10;
            while (broj < 10)
            {
                Console.WriteLine(++broj);
            }

            int suma = 0;
            for(int j= 1; j<=100; j++)
            {
                suma += j;

            }
            Console.WriteLine(suma);





        
        
        }


    }
}
