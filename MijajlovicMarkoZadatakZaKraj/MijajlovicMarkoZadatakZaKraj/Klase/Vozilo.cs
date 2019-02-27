using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MijajlovicMarkoZadatakZaKraj.Klase
{
    class Vozilo
    {
        private string vrsta;
        private int maxBrzina, brojKotaca;

        public void setBrojKotaca(int brojKotaca)
        {
            this.brojKotaca = brojKotaca;
        }

        public int getBrojKotaca()
        {
            return this.brojKotaca;
        }

        public void setMaxBrzinaMotora(int maxBrzina)
        {
            this.maxBrzina = maxBrzina;
        }

        public int getMaxBrzinaMotora()
        {
            return this.maxBrzina;
        }

        public void setVrsta(string vrsta)
        {
            this.vrsta = vrsta;
        }

        public string getVrsta()
        {
            return this.vrsta;
        }
       
        public void unosPodataka()
        {
            Console.WriteLine("Unesite broj kotaca: ");
            setBrojKotaca(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Unesite vrstu vozila: ");
            setVrsta(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Vrsta: " + vrsta +
                "Broj kotaca: " + brojKotaca +
                "Maksimalna brzina: " + maxBrzina;
        }

        public bool carCheck()
        {
            if (brojKotaca == 4 && vrsta == "Automobil" || vrsta == "Auto" || vrsta == "automobil" || vrsta == "auto")
            {
                return true;
            }
            else return false;
        }

        public void carMultiplier()
        {
            double multiplied;

            multiplied = (maxBrzina * 0.03) * 100;

           // Console.WriteLine(multiplied.ToString());

            Console.WriteLine("Vrsta: " + vrsta +
                "Broj kotaca: " + brojKotaca +
                "Maksimalna Brzina" + multiplied);

        }
    }

    
}
