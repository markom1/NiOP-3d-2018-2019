using System;
using System.IO;

namespace MijajlovicMarkoSystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();


            // Provjera postojanja unešenog direktorija
            // Ako postoji, ispiši sve datoteke u direktoriju
            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke: ");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }


            // Provjera postojanja poddirektorija TEST
            // Ako ne postoji, kreiramo ga
            string putanjaPod = putanja + "\\TEST";
            if (!Directory.Exists(putanjaPod))
            {
                Directory.CreateDirectory(putanjaPod);
            }

            // Ispis svih poddirektorija
            Console.WriteLine("Poddirektoriji: ");
            foreach (string poddirektorij in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(poddirektorij);
            }

            // Brisanje poddirektorija TEST
            Directory.Delete(putanjaPod);

            // Ponovno ispisvanje svih poddirektorija
            Console.WriteLine("Nakon brisanja direktorija TEST: ");
            foreach (string poddirektorij in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(poddirektorij);
            }

            Console.ReadKey();
        }
    }
}
