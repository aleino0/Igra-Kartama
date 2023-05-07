using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igra_karti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ukupno = 0;
            Console.WriteLine("Unesite brojeve od 1 od 13 kako biste dostigli 31.");

            do
            {
                unos: Console.WriteLine("unesi broj");
                int karta = Convert.ToInt32(Console.ReadLine());
                if (karta > 0 && karta < 14)
                {
                    ukupno += karta;
                }
                else
                {
                    Console.WriteLine("Neispravan unos: ");
                    goto unos;
                }
            } while (ukupno < 31);
            
            if(ukupno == 31) { Console.WriteLine("Pobjedili ste!!!"); }
            else { Console.WriteLine("Izgubili ste."); }

            Console.ReadKey();
        }
    }
}
