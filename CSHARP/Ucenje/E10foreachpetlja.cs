using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10foreachpetlja
    {
        public static void Izvedi()
        {
            Console.Write("Unesi ime svog grada: ");

            string grad = Console.ReadLine();

            Console.Write(grad);

            char[] znakovigrad = new char[6];
            znakovigrad[0] = 'o';
            znakovigrad[1] = 's';
            znakovigrad[2] = 'i';
            znakovigrad[3] = 'j';
            znakovigrad[4] = 'e';
            znakovigrad[5] = 'k';

            for(int i = 0; i<6; i++)
            {


                Console.Write(znakovigrad[i]);
            }

            for (int i = 0; i < grad.Length; i++) 
            {
                Console.Write(grad[i]);

            }


            foreach(char znak in znakovigrad)
            {
                Console.Write(znak);

            }

            foreach(char c in grad)
            {
                Console.WriteLine(c);
            }

            for (int i = grad.Length - 1; i >= 0; i--)
            {
                Console.Write(i);
            }

            

            

            









        }


    }
}
