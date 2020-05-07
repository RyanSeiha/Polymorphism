using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Epson : Printer
    {
        public override void show()
        {
            Console.WriteLine("Epson Display Dimension : 10*11");
        }
        public override void print()
        {
            Console.WriteLine("Epson Printer Printing......");
        }
    }
}
