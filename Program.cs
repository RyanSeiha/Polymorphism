using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer;

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet \n");

            Console.Write("Pilih Berdasarkan Nomer Printer : ");
            int NoPrinter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            if (NoPrinter == 1)
            {
                printer = new Epson();
            }
            else if (NoPrinter == 2)
            {
                printer = new Canon();
            }
            else
            {
                printer = new LaserJet();
            }

            printer.show();
            printer.print();

            Console.ReadKey();
            
        }
    }
}
