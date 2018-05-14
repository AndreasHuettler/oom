using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Computer
    {

        public Computer(int value_serNo, string value_manufacturer, decimal value_price)
                {
                    if (string.IsNullOrWhiteSpace(value_manufacturer)) throw new ArgumentException("Manufacturer must not be empty.");
            Manufacturer = value_manufacturer;
            SerNo = value_serNo; 
            Price = value_price;

                }




        private int SerNo;


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

        
    }
}



