using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E03operatori
    {
        public static void Izvedi()
        {
            //console.Writeline("E03):
            //operatori rad s varijablama 
            //= je dodjela vrijednosti 
            // == dodjela jednakosti -> bool 

            int i = 7; // sada zamislimo da je korisnik unjeo 7

            Console.WriteLine(i==7);

            // operatori +,-,*,/

            int k = 2, l = 1;

            Console.WriteLine(l/k); // jeljenje 2 int daje int 

            // mehanizam cast -> interpretacija broja u drugom tipu podatka 

            Console.WriteLine(l/(float)k);


            //!= -> nije jednako 
            Console.WriteLine(i!=k);

            // operator modulo %

            Console.WriteLine("5%2={0}",5 % 2 );

            Console.WriteLine("4%2={0}", 4 % 2);


            // uvecavanje za 1 

            int b = 0;

            // uvecaj za 1 

            b = b + 1;

            // kraće 

            b += 1;

            //najkraće 

            b++;

            

            Console.WriteLine(b);

            // incremnet i decrement (i++ i i--)

            b = 0;

            // b++ prvo koristi pa uveća 
            Console.WriteLine(b++);

            //++b prvo uveća pa onda koristi 
            Console.WriteLine(++b);

            // ova pravila isto vrijede i za b-- te --b

            int t = 0, c = 1;
            t = c++ + t;
            c += ++t;
            Console.WriteLine(c+t);



        }
    }
}
