using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07Z2
    {
        // Za dva unesena cijela broja ispisati sve brojeve između njih
        
      public static void Izvedi()
        {
            Console.WriteLine("Unesite prvi broj ");
            int pb = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj");
            int db = int.Parse(Console.ReadLine());
            for (int i = pb; i<db; i++)
            {
                Console.WriteLine(i);
            }
        }



    }
}
