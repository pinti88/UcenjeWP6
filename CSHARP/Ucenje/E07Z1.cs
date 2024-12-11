using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07Z1
    {
        // Program od korisnika unosi cijeli broj

        //  Ako je uneseni broj paran, progra ispisuje zbroj svih brojeva od 1 do unesenog
        // inače program ispisuje svaki neparni broj od 1 do unesenog

        public static void Izvedi()
        {
            Console.WriteLine("Unesite cijeli broj; ");
        int broj = int.Parse(Console.ReadLine());
            if (broj % 2 == 0)
            {
              int sum = 0;
                for (int i = 1; i <= broj; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
            else
            {
                for (int i = 1; i<=broj; i++)
                {
                    if (i % 2 != 0)
                    {
                        if (i == broj || i == broj - 1)
                        {
                            Console.Write(i);
                        }
                        else
                        {
                            Console.Write(i +", ");
                        }
                    }

                }
            }

            
        
        
        }




            

                
       

    }
}
