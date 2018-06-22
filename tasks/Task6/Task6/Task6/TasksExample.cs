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
        static int tasknumber = 0;
        static Random random = new Random();


        public static async void Run()
        {
            
            
            int eingabe = 0;
            var tasks = new List<Task>();

            Console.WriteLine("Gib eine grosse Zahl ein: ");
            var stringeingabe = Console.ReadLine();
            if (int.TryParse(stringeingabe, out eingabe))
            {
                
                while (eingabe != 0)
                {
                    
                    
                    /*
                    if (await Calc())
                    {
                        var task = Task.Run(() =>
                        {
                            Console.WriteLine("[Waited Task] ... doing something");
                        }).ContinueWith(TASK => Console.WriteLine("[ContinueWith Task " + tasknumber + "] ... continuing doing something."));
                    }
                    */

                    /*
                    var task = Task.Run(() =>
                    {

                        if(await Calc())
                        {

                        }
                    }).ContinueWith(TASK => Console.WriteLine("[ContinueWith Task " + tasknumber + "] ... doing something.")); 


                        tasks.Add(task);
                    */




                    /*
                    foreach (var t in tasks) {
                        t.ContinueWith(TASK => Console.WriteLine("[ContinueWith] ... doing something."));
                    }
                    */
                    Thread.Sleep(1000);
                    eingabe--;
                    Console.WriteLine(eingabe);
                }
                var cts = new System.Threading.CancellationTokenSource();
            }
            
            
        }
        /*
        public static async Task<bool> divideByTwo(int eingabe, CancellationToken ct)
            {

             if((eingabe % 2) == 0)
             {
                ct.ThrowIfCancellationRequested();
                if
             }
            }
            */

        public static Task<bool> Calc()
        {
            return Task.Run(() =>
             {
                 tasknumber++;
                 Console.WriteLine("[Task " + tasknumber + "] Calculating...");
                 //Task.Delay(TimeSpan.FromSeconds(5.0 + random.Next(7))).Wait();
                 Console.WriteLine("[Task " + tasknumber + "] ... Calculation done");
                 return true;
             });

        }

        public static async void AsyncMethod()
        {
            if (await Calc()) Console.WriteLine("true");
        }
    }
}
