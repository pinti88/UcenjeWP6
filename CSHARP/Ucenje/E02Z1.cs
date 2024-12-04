using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    //napisite progra, koji unosi ime i broj godina 

    // program ispisuje odma osoba xxxxx ima yy godina 


    internal class E02Z1
    {
     public static void Izvedi()
        {
            Console.Write("unesi ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("unesi broj godina (cijeli broj): ");
            int godine = int.Parse(Console.ReadLine());

            Console.WriteLine("osoba {0} ima {1} godina.", ime, godine);
        
        
        
        
        
        }





    }
}
