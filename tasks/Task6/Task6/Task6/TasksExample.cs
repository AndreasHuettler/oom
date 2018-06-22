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


        public static void Run()
        {
            int eingabe = 0;

            Console.WriteLine("Enter a number (e.g.:  5  ): ");
            var stringeingabe = Console.ReadLine();
            if (int.TryParse(stringeingabe, out eingabe))
            {
                while (eingabe != 0)
                {
                    AsyncMethod();
                    
                    Thread.Sleep(1000);
                    eingabe--;
                    Console.WriteLine("Counter: " + eingabe);
                }
            }
        }
        
        public static Task<bool> Calc()
        {
            return Task.Run(() =>
             {
                 tasknumber++;
                 Console.WriteLine("[Task " + tasknumber + "] Calculating...");
                 Console.WriteLine("[Task " + tasknumber + "] ... Calculation done");
                 return true;
             });

        }

        public static async void AsyncMethod()
        {
            if (await Calc())
            {
                var task = Task.Run(() =>
                {
                    Console.WriteLine("[Waited Task] ... executed after Task" + tasknumber + " was finished");
                }).ContinueWith(TASK => Console.WriteLine("[ContinueWith Task " + tasknumber + "] ... continuing doing something with the Waited Task."));
            }
        }
    }
}
