using System;
using System.IO;

namespace MijajlovicCitanjeDatoteka
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Ucenik\Documents\datoteka.txt");

            // Čitanje datoteke liniju po liniju
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            // Zatvaramo datoteku
            sr.Close();

            Console.ReadKey();
        }
    }
}
