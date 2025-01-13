using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Z7zbrojsamoglasnika
    {

        public static void Izvedi()
        {
            for (; ; )
            {
                string tekst = E12Metode.UcitajString("Unesi nekakav izraz (STOP za kraj): ");
                if (tekst.ToUpper() == "STOP")
                {
                    Console.WriteLine("Doviđenja");
                    break;
                }

                int brojacSamoglasnika = 0;

                try
                {
                    int.Parse(tekst);
                    Console.WriteLine("Ne smije biti broj");
                    continue;
                }
                catch
                {


                }

                for (int i = 0; i < tekst.Length; i++)
                {
                    char c = char.ToLower(tekst[i]);


                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')

                    {
                        brojacSamoglasnika++;
                    }



                }

                
                Console.WriteLine("Broj samoglasnika u unesenom tekstu je: " + brojacSamoglasnika);

            }

        }
        

    }
}
