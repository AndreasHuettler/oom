using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp1 = new Computer(12345, "Asus", 999);
            Console.WriteLine(comp1.printStatus());
            Console.WriteLine("Preis vird verändert...");
            comp1.Price = 1999;
            Console.WriteLine("Preis wurde verändert.");
            Console.WriteLine(comp1.printStatus());


        }
    }
}


