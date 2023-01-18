using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspitZnanja7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Broj;

            Console.WriteLine("Unesite broj: ");
            Broj = Convert.ToInt32(Console.ReadLine());

            if (Broj % 4 == 0 && Broj % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 6 i sa 4.");
            }
            else if (Broj % 4 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 4.");
            }
            else if (Broj % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 6.");
            }
            else
            {
                Console.WriteLine("Broj nije djeljiv ni sa 6 ni sa 4.");
            }

            Console.ReadKey();
        }
    }
}
