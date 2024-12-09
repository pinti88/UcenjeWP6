using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07ForPetlja

    {

        public static void Izvedi()
        {

            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("{0}. Osijek iz petlje", i);


            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("{0}. Unazad", i);


            }
            // ugnježđenja petlja 
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("\t{0}", i * j);

                }
                Console.WriteLine();
            }

            //DZ formatirati brojeve prema desno

            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {

                sum += i;

            }
            Console.WriteLine(sum);
            int x = 100;
            Console.WriteLine();
            Console.WriteLine((x + 1) * x / 2);

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    //Console.WriteLine(i);
                    Console.Write("{0},", i);
                }

                //DZ manuti zadnji zarez 



            }



            Console.WriteLine();
            int idiod = 12;
            int idido = 34;

            for (int i = idiod; i < idido; i++)
            {
                Console.WriteLine(i);
            }


            int[] brojevi = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine(brojevi[i]);
            }


            int[,] tablica =
                {
            {1,2,3},
            {4,5,6},
            {6,7,8}
            };

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica [i, j] + " ");
                }
                Console.WriteLine();



            }


            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue; 
                }

                if (i == 7)
                {
                    break;
                }
                Console.WriteLine(i);


            }
            // ovo nije beskonacna petlja 
            for (int i = 0; i >= 0; i++)
            {
                Console.WriteLine(i);
                break;
            }

            // beskonacna petlja 
            for(; ; )
            {
                Console.WriteLine(new Random().NextInt64() + "" + new Random().NextInt64() + "" + new Random().NextInt64() + "" + new Random().NextInt64());
            Thread.Sleep(300);
            break;

            }




        }



    }

}    
        

       



