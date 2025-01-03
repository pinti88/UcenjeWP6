using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class CiklicnaTablica
    {
        public static void Izvedi()
        {
            int BrojRedaka = 5;

            int BrojStupaca = 5;



            int[,] tablica = new int[BrojRedaka, BrojStupaca];



            int broj = 1;

            int GornjaGranica = 0;

            int DonjaGranica = BrojRedaka - 1;

            int LijevaGranica = 0;

            int DesnaGranica = BrojStupaca - 1;



            while (broj <= BrojRedaka * BrojStupaca)

            {

                

                for (int i = DesnaGranica; i >= LijevaGranica && broj <= BrojRedaka * BrojStupaca; i--)

                {

                    tablica[DonjaGranica, i] = broj++;

                }

                DonjaGranica--;



                

                for (int i = DonjaGranica; i >= GornjaGranica && broj <= BrojRedaka * BrojStupaca; i--)

                {

                    tablica[i, LijevaGranica] = broj++;

                }

                LijevaGranica++;



                

                for (int i = LijevaGranica; i <= DesnaGranica && broj <= BrojRedaka * BrojStupaca; i++)

                {

                    tablica[GornjaGranica, i] = broj++;

                }

                GornjaGranica++;



                

                for (int i = GornjaGranica; i <= DonjaGranica && broj <= BrojRedaka * BrojStupaca; i++)

                {

                    tablica[i, DesnaGranica] = broj++;

                }

                DesnaGranica--;

            }



            

            for (int i = 0; i < BrojRedaka; i++)

            {

                for (int j = 0; j < BrojStupaca; j++)

                {

                    Console.Write(tablica[i, j].ToString().PadLeft(4)); 

                }

                Console.WriteLine(); 

            }
        }
    }
}
