using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;

namespace Task6
{
    class PushWithSubjectExample
    {
        public static void run()
        {
            var source = new Subject<Computer>();

            source
                .Sample(TimeSpan.FromSeconds(1.0))
                .Subscribe(x => Console.WriteLine($"received: SerNo: " + x.SerNo + " Manufacturer: " + 
                x.Manufacturer + " Price: " + x.Price))
                ;

           

            var t = new Thread(() =>
            {
                var i = 0;
                while (true)
                {
                    Computer comp = new Computer(i, "RandomManufacturer", 2999);
                    Thread.Sleep(2500);
                    source.OnNext(comp);
                    Console.WriteLine($"sent {i}");
                    i++;
                }
            });
            t.Start();
        }
    }
}
