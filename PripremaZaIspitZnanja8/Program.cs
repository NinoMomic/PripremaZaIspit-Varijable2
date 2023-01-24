using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspitZnanja8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu bez PDV-a:");
            string sD = Console.ReadLine();
            double bezPDV = Convert.ToDouble(sD);
            Console.WriteLine("Unesite cijenu s PDV-om:");
            sD = Console.ReadLine();
            double sPDV = Convert.ToDouble(sD);
            if (sPDV < bezPDV)
            { 
            Co
                    nsole.WriteLine("Cijene nisu ispravno unešene");
            }
            else
            { 
            Console.WriteLine("PDV iznosi {0} %",
            (sPDV - bezPDV) / bezPDV * 100);
             
            Console.ReadKey();
        }
    }
}
