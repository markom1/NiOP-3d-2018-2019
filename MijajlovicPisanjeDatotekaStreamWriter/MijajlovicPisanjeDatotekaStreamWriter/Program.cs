using System;
using System.IO;

namespace MijajlovicPisanjeDatotekaStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Unesite prezime: ");
            string prezime = Console.ReadLine();

            // Podatke upisujemo u datoteku
            Console.WriteLine("\n-- Zapisujemo u datoteku...");
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Ucenik\Documents\datoteka.txt"))
            {
                sw.WriteLine("Ime: {0}", ime);
                sw.WriteLine("Prezime: {0}", prezime);
            }

            // Podatke upisujemo u datoteku
            Console.WriteLine("\n-- Pročitano iz datoteke: ");
            using (StreamReader sr = new StreamReader(@"C:\Users\Ucenik\Documents\datoteka.txt"))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }

            Console.ReadKey();
        }
    }
}
