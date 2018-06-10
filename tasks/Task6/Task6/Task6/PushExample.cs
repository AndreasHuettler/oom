using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    class PushExample
    {


        public static void Run()
        {
            var w = new Form() { Text = "Push Example", Width = 800, Height = 600 };

            // C# events
            w.MouseMove += (s, e) => Console.WriteLine($"[MouseMove] ({e.X}, {e.Y})");

            // Rx observables
            //var moves = Observable.FromEventPattern<MouseEventArgs>(w, "MouseMove").Select(x => x.EventArgs);

            //moves
            //    .Subscribe(e => WriteLine($"[A] ({e.X}, {e.Y})"))
            //    ;

            //moves
            //    .Sample(TimeSpan.FromSeconds(1))
            //    .Subscribe(e => WriteLine($"[B] ({e.X}, {e.Y})"))
            //    ;

            //moves
            //    .Throttle(TimeSpan.FromSeconds(0.2))
            //    .Subscribe(e => Console.WriteLine($"[C] ({e.X}, {e.Y})"))
            //    ;

            Application.Run(w);
        }
    }
}
