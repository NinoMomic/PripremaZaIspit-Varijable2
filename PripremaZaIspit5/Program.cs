using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspit5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unos;

            unos:Console.WriteLine("Unesite recenicu: ");
            unos = Console.ReadLine();

            if (unos.Length > 5)
            {
                string ispis = unos.Substring(2, unos.Length - 2);
                Console.WriteLine(ispis);
            }
            else
            {
                goto unos;
            }
            Console.ReadKey();  
        }
    }
}
