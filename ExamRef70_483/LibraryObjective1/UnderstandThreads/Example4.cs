using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryObjective1
{
    // Stoping a thread
    public class Example4 : IExample
    {
        private void Main()
        {
            bool stopped = false;

            // The thread is initialized with a lambda expression
            Thread t = new Thread(new ThreadStart(() =>
            {
                // this thread check variable stopped value to decide stopping or not
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }

            }));

            t.Start();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }

        public void Example_Execute() => Main();
    }
}
