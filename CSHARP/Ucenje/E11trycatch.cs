using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E11trycatch
    {
        public static void Izvedi()
        {
            //Console.WriteLine("e11");

            int broj;
            
            while (true)
            {


            try
            {
                
                Console.Write("Unesi cijeli broj: ");
                broj = int.Parse(Console.ReadLine());
                    break;


            }
            catch
            {
                Console.WriteLine("Nisi unio cijeli broj!");
            }



            }
            //Console.WriteLine("Bravo unjeli ste {0}", broj);

            int godine;

            while (true)
            {

                Console.WriteLine("unesi svoj broj godina: ");
                try
                {
                    godine = int.Parse(Console.ReadLine());
                    if (godine <1 || godine> 104)
                    {
                        Console.WriteLine("Uneseni broj dodina nije dobar!");
                        continue;
                    }
                    break;
                }
                catch 
                {
                    Console.WriteLine("Nisi dobro unio broj godina!");
                    
                }










            }

            Console.WriteLine("Broj godina osobe je {0}", godine);



            // Unesi grad

            string grad;
            int ascci;
            bool ok;
            
            for (; ; )

            {
                Console.Write("unesi ime grada: ");
                grad = Console.ReadLine().Trim();
                if(grad.Length == 0)
                {
                    Console.WriteLine("Nisi unio ime grada ");
                    continue;
                }
                // ovdje sam siguran da je nesto unjeo
                
                try
                {
                    int.Parse(grad);
                    Console.WriteLine("Ime grada ne moze biti broj");
                    continue;
                }
                catch 
                {


                    
                }
                //problem Osije, Osijek, Osijek

                ok = true;
                foreach(char c in grad.ToUpper())
                {
                    ascci = (int)c;
                    if(ascci < 65 || ascci > 90)
                    {
                        ok = false;
                        break;
                    }

                } 
                if (!ok)
                {
                    Console.WriteLine("Problem s unosom u nazivu grada");
                    continue;
                }
                                             
                break;


            }

            Console.WriteLine("Unjeli ste: >{0}<", grad);
            

            
            


        }





    }
}
