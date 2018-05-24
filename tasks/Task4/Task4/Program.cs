﻿using System;
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
            Console.WriteLine();


            Console.WriteLine(comp1.printStatus() + comp1.Beschreibung());

            Console.WriteLine();
            Console.WriteLine("Array wird erzeugt...");

            var geraete = new InformationsInterface[]
            {
                new Computer(1, "Asus", 1233),
                new Computer(2, "Dell", 1998),
                new Computer(3, "HP", 2499),
                new Computer(4, "Lenovo", 1699),
                new TV("Samsung", 999),
                new TV("LG", 1499),
            };

            Console.WriteLine("Array wurde erzeugt");
            Console.WriteLine();
            Console.WriteLine("Array wird ausgegeben: ");


            foreach (var i in geraete)
                        {
                            Console.WriteLine(i.Beschreibung());
                        }


        }
    }
}

