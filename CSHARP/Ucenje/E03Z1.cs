namespace Ucenje
{

    // Program od korisnika unosi dva cijela broja
    // Program ispisuje u novim redovima
    // 1. zbroj
    // 2. razliku drugog i prvog
    // 3. umnožak
    // 4. zbroj kvadrata prvog i drugog broj
    // 5. kvocijent prvog i drugog broja
    internal class E03Z1
    {
        public static void Izvedi()
        {
            Console.Write("Unesi prvi cijeli broj:");
            int prvibroj = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi cijeli broj:");
            int drugibroj = int.Parse(Console.ReadLine());

            //zbrajanje 
            int zbroj = prvibroj + drugibroj;
            Console.WriteLine("zbroj:" + zbroj);


            // razlika ( oduzimanje ) 

            int razlika = prvibroj - drugibroj;
            Console.WriteLine("razlika: " + razlika);

            // umnozak

            int umnozak = prvibroj * drugibroj;
            Console.WriteLine("umnozak: " + umnozak);

            // zbroj kvadrata 

            int prvibrojkvadrat = prvibroj + prvibroj;
            int drugibrojkvadrat = drugibroj + drugibroj;

            Console.WriteLine("zbroj kvadrata: " + prvibrojkvadrat * drugibroj);

            // kvocijent prvog i drugog broja 

            int kvocijent = prvibroj % drugibroj;
            Console.WriteLine("kvocijent: " + kvocijent);




        }

    }
}
