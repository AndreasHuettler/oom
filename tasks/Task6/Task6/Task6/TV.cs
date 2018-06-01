using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class TV : InformationsInterface
    {
        public TV(string manufacturer, decimal price)
        {
            Manufacturer = manufacturer;
            Price = price;

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
            return " Ich bin ein TV";

        }
    }
}
