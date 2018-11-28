using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MijajlovicInputOutputKlasa
{
    class Program
    {
        static void Main(string[] args)
        {
            string putanja = @"C:\Users\Ucenik\Documents";

            //ispis dokumenata u mapi (preko foreach)
            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke: ");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }

            //ispis dokumenata u mapi (preko for)
            string[] putanje = Directory.GetFiles(putanja);

            // i < Directory.GetFiles(putanja).Length
            for (int i = 0; i < putanje.Length; i++)
            {
                //Directory.GetFiles(putanja)[i]
                Console.WriteLine(putanje[i]);
            }

            Console.WriteLine();
            Console.WriteLine("///////////");
            Console.WriteLine();

            //kreiranje i brisanje mape
            string mapa = putanja + "\\test";

            if (Directory.Exists(mapa))
            {
                Console.WriteLine("\nMapa izbrisana.");
                Directory.Delete(mapa);
            }
            else
            {
                Console.WriteLine("\nMapa kreirana.");
                Directory.CreateDirectory(mapa);
            }

            //ispis podmapa
            if (Directory.Exists(putanja))
            {
                Console.WriteLine("\nPodmape: ");
                foreach (string datoteka in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }

            Console.ReadKey();
        }
    }
}
