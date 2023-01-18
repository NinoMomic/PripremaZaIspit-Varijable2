using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspitZnanja6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=5, y=3, z=2;

            if(z==(x*x)+(y*y))
            {
                Console.WriteLine("Ovo su stranice pravokutnog trokuta. ");
            }
            else
            {
                Console.WriteLine("Ovo nisu stranice pravokutnog trokuta. ");
            }

            Console.ReadKey();
        }
    }
}
