using System;
using System.IO;

namespace KlasaFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite vaše ime: ");
            string ime = Console.ReadLine();

            string datoteka = "ime.txt";

            // Provjera postojanja ime.txt
            
            if (File.Exists(datoteka))
            {
                // Ako postoji kopiramo ju u backup direktorij
                if (!Directory.Exists("backup"))
                {
                    Directory.CreateDirectory("backup");
                }

                File.Copy(datoteka, "backup\\ime" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss" + ".txt");

                File.Delete(datoteka);
            }

            File.WriteAllText(datoteka, ime);
        }
    }
}
