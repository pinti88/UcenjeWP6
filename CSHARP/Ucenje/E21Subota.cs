using Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E21Subota
    {

        public E21Subota()
        {
            //Console.WriteLine(" Hello from E21 Subota");
            Slucajnibrojevi();

        }

        private void Slucajnibrojevi()
        {
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(20, 31));
            }


        }

 
    }


}


