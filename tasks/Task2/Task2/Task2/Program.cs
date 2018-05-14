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
            Console.WriteLine("erster Computer: " + comp1.SerNo + " " + comp1.Manufacturer + " " + comp1.getPrice());


        }
    }
}


