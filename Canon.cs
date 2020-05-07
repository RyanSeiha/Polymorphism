using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Canon : Printer
    {
        public override void show()
        {
            Console.WriteLine("Canon Display Dimension : 9.5*12");
        }
        public override void print()
        {
            Console.WriteLine("Canon Printer Printing......");
        }
    }
}
