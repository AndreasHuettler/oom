using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task6
{
    class TasksExample
    {
        public static void Run()
        {
            var random = new Random();

            int eingabe = 0;

            Console.WriteLine("Gib eine grosse Zahl ein: ");
            var stringeingabe = Console.ReadLine();
            if (int.TryParse(stringeingabe, out eingabe))
            {
                while (eingabe != 0)
                {
                    var task = Task.Run(() =>
                    {
                        Console.WriteLine("Calculating...");
                        Task.Delay(TimeSpan.FromSeconds(5.0 + random.Next(7))).Wait();
                        Console.WriteLine("... Calculation done");
                    });
                    Thread.Sleep(1000);
                    eingabe--;
                    Console.WriteLine(eingabe);
                }
                var cts = new System.Threading.CancellationTokenSource();
            }
            

        }
        public static async Task<bool> divideByTwo(int eingabe, CancellationToken ct)
            {

             if((eingabe % 2) == 0)
             {
                ct.ThrowIfCancellationRequested();
                if
             }
            }
    }
}
