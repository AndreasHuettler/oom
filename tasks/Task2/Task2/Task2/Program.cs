using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
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


            /*

            //Array von Computern wird erstellt
            var CompArray = new Computer[]
            {
                new Computer(11, "HP", 2333),
                new Computer(2, "Acer", 1098),
                new Computer(3, "Asus", 1399),
                new Computer(4, "Fujitsu", 1299),
            };



            string jsonstring = JsonConvert.SerializeObject(CompArray);
            Console.WriteLine(jsonstring);
            Directory.CreateDirectory(@"c:\temp\json");
            File.WriteAllText(@"c:\temp\json\jsonfile.json", jsonstring);


            string readJson = File.ReadAllText(@"c:\temp\json\jsonfile.json");
            Console.WriteLine();
            Console.WriteLine(readJson);
            Console.WriteLine();

           List<Computer> readFromDiskContainer = JsonConvert.DeserializeObject<List<Computer>>(readJson);      

            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("eingelesene Daten:");
            Console.WriteLine();
            Console.WriteLine();
            foreach (var j in readFromDiskContainer)
            {
                
                Console.WriteLine(j.printStatus());
            }



            */

            Console.WriteLine();
            Console.WriteLine("Neu: ");
            Console.WriteLine();

            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            string jsonstringNeu = JsonConvert.SerializeObject(geraete, settings);
            Console.WriteLine(jsonstringNeu);
            Directory.CreateDirectory(@"c:\temp\json");
            File.WriteAllText(@"c:\temp\json\jsonfileNew.json", jsonstringNeu);

            string readJsonNew = File.ReadAllText(@"c:\temp\json\jsonfileNew.json");
            var readFromDiskContainerNeu = JsonConvert.DeserializeObject<InformationsInterface[]>(readJsonNew, settings);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("eingelesene Daten:");
            Console.WriteLine();
            Console.WriteLine();
            foreach (var j in readFromDiskContainerNeu)
            {

                Console.WriteLine(j.Beschreibung());
            }

        }
    }
}


