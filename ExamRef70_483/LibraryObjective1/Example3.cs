using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryObjective1
{
    // Using the ParameterizedThreadStart
    public static class Example3
    {
        public static void ThreadMethod(object o)
        {
            int num = 0;
            if (!int.TryParse(o.ToString(), out num)) throw new Exception("Invalid casting.");

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Thread Proc: {0}", i);
                Thread.Sleep(0);
            }

            // Loop method if console key tapped is empty
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) Example3_Main();
        }

        public static void Example3_Main()
        {
            // (1)
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));

            Console.Write("Please enter the number: ");
            string num = Console.ReadLine();

            // passing parameter "num" to thread method
            t.Start(num);
            t.Join();
        }
    }

    // (1) The Thread constructor has another overload that takes an instance of a ParameterizedThreadStart delegate.
    // This overload can be used if you want to pass some data through the start method of your thread to your worker method.
}
