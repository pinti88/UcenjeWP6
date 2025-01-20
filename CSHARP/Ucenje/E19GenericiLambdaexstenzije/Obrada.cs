using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E19GenericiLambdaexstenzije
{
    //T je type ali moze ici bilo koje slovo
    public class Obrada<T> : ISucelje where T : Entitet
    {
        public T? ObjekObrade { get; set; }
        public  List<T>? ListaObrade { get; set; }

        public void OdradiPosao()
        {
            posao();
        }

        public void posao()
        {

            Console.WriteLine(ObjekObrade?.Sifra);

        }

    }
}
