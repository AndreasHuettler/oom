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
            p_Manufacturer = value_manufacturer;
            SerNo = value_serNo; 
            p_Price = value_price;

                }

        private decimal p_Price;
        private string p_Manufacturer;
        private decimal p_SerNo;
        

        public string Manufacturer {
            get
            {
                return Manufacturer; 
            }
            set
            {
                Manufacturer = value;
            }
        }

        public int SerNo
        {
            get; set;
        }

        public void updatePrice(decimal price)
        {
            p_Price = price;
        }

        public decimal getPrice()
        {
            return p_Price;
        }

        
    }
}



