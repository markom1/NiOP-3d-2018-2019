using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klaseAndObjekti.Klase;

namespace klaseAndObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo vozilo = new Vozilo();   
            string odgovor;

            do
            {
                vozilo.unosPodataka();
                Console.WriteLine(vozilo.ispis());
                Console.WriteLine("\nZelite li upisati jos jedno vozilo? (da/ne)");

                odgovor = Console.ReadLine();
                Console.WriteLine();
            }
            while (odgovor == "da");

            /*          Vozilo avion = new Vozilo();

                        avion.setBrojKotaca(6);
                        avion.setLeti(true);
                        avion.setPliva(false);
                        avion.setVozi(true);
                        avion.setVrsta("Cessna");
                        avion.setOznaka("1312");

                        Vozilo kamijon = new Vozilo(8, false, false, true, "TAM", "RI1987AR");

                        Console.WriteLine("Vrsta: " + avion.getVrsta() + " Oznaka: " +
                            avion.getOznaka() + "\nLeti: " + avion.getLeti() + "\nPlovi: "+ avion.getPliva()
                            + "\nVozi: " + avion.getVozi() + "\nBroj kotača: "+ avion.getBrojKotaca() + "\n");

                        Console.WriteLine(kamijon.ToString());
                        Console.WriteLine(avion.ispis());
            */
        }
    }

    
}
