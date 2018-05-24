using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    [TestFixture]
    public class Tests
    {
        
        //Test1:
        [Test]
        public void CreateComputerTest()
        {
            var c = new Computer(12345678, "Manufacturer", 9999);
            var c1 = new Computer(12345, "Hersteller1", 29);
            
            Assert.IsNotNull(c);
            Assert.IsTrue(c.Manufacturer == "Manufacturer");
            Assert.NotZero(c.Price);

            Assert.IsNotNull(c1);
            Assert.IsTrue(c1.Manufacturer == "Hersteller1");
            Assert.NotZero(c1.Price);

        }

        //Test2:
        [Test]
        public void CreateTVTest()
        {
            var tv = new TV("Toshiba", 8999);
            var tv1 = new TV("Hersteller2", 998);

            Assert.IsTrue(tv.Manufacturer == "Manufacturer");
            Assert.NotZero(tv.Price);

            Assert.IsTrue(tv1.Manufacturer == "Herstelelr2");
            Assert.NotZero(tv1.Price);
        }

        //Test3:
        [Test]
        public void TVgetPriceTest()
        {
            var c3 = new TV("Hersteller3", 889);
            c3.Price = 989;
            Assert.IsTrue(c3.Price == 989);
        }

        //Test4:
        [Test]
        public void TVgetManufacturerTest()
        {
            var c4 = new TV("Hersteller4", 289);
            c4.Manufacturer = "Hersteller4Neu";
            Assert.IsTrue(c4.Manufacturer == "Hersteller4Neu");
        }

        //Test5:
        [Test]
        public void getPriceTest()
        {
            var c5 = new Computer(12215, "Hersteller5", 589);
            Assert.NotZero(c5.Price);
        }

        //Test6:
        [Test]
        public void getManufacturerTest()
        {
            var c6 = new Computer(122163, "Hersteller6", 789);
            Assert.IsTrue(c6.Manufacturer == "Hersteller6");
        }

        //Test7:
        [Test]
        public void setPriceTest()
        {
            var c7 = new Computer(12217, "Hersteller7", 7289);
            c7.Price = 7389;
            Assert.IsTrue(c7.Price == 7389);
        }

        //Test8:
        [Test]
        public void setManufacturerTest()
        {
            var c8 = new Computer(12218, "Hersteller8", 8289);
            c8.Manufacturer = "Hersteller8Neu";
            Assert.IsTrue(c8.Manufacturer == "Hersteller8Neu");
        }
    }
}
