using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MijajlovicMarkoZadatakZaKraj.Klase;

namespace MijajlovicMarkoZadatakZaKraj
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo vozilo = new Vozilo();
            Vozilo motor = new Vozilo();

            

            if (vozilo.carCheck() == true)
            {
                vozilo.unosPodataka();
                vozilo.carMultiplier();
            }
            else vozilo.ToString();

        }
    }
}
