using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijajlovicTimeSpanZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime novaGodina = new DateTime(DateTime.Now.Year + 1, 1, 1);
            TimeSpan preostalo = novaGodina - DateTime.Now;

            Console.WriteLine("Do nove godine preostalo je: ");
            Console.WriteLine("{0} dana {1} sati {2} minuta {3} sekundi", preostalo.Days, preostalo.Hours, preostalo.Minutes, preostalo.Seconds);

            Console.WriteLine("U danima: " + preostalo.TotalDays);
            Console.WriteLine("U satima: " + preostalo.TotalMinutes);
            Console.WriteLine("U minutama: " + preostalo.TotalMinutes);
            Console.WriteLine("U sekundama: " + preostalo.TotalSeconds);

            Console.ReadKey();
        }
    }
}
