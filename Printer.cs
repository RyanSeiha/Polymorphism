using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Printer
    {
        public string Name { get; set; }

        public virtual void show() 
        {
            Console.WriteLine("The Animal speaks");
        }
        public virtual void print()
        {
            Console.WriteLine("Printer Yang dipilih");
        }
    }
}
