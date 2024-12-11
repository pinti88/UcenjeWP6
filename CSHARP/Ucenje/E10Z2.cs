using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10Z2
    {

        public static void Izvedi()
        {

            int broj = 17;
            bool prim = true;
            for (int i = 2; i <= broj; i++)
            {
                if(broj%i == 0)
                {
                    prim = false;
                    break;
                }
            }
            Console.WriteLine(prim ? "da" : "ne");
        }
    }
}
