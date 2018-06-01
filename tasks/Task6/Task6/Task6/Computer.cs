using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Computer : InformationsInterface
    {

        public Computer(int SerNo, string Manufacturer, decimal Price)
                {
                    if (string.IsNullOrWhiteSpace(Manufacturer)) throw new ArgumentException("Manufacturer must not be empty.");
            this.Manufacturer = Manufacturer;
            this.SerNo = SerNo;
            this.Price = Price;

                }


        public int SerNo
        {
            get; set;
        }

        public string printStatus()
        {
            return "Seriennummer: " + SerNo + " Hersteller: " + Manufacturer + " Preis: " + Price;
        }
        
        public string Manufacturer
        {
            get; set;
        }

        public decimal Price
        {
            get; set;
        }

        public string Beschreibung()
        {
            return " Ich bin ein Computer";
        }
    }
}



