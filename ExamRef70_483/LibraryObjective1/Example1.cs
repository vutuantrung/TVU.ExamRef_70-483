using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryObjective1
{
    // Creating a thread with the Thread class
    public static class Example1
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Example1_Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }

            // This is called on the main thread to let it wait until the other thread finishes.
            t.Join();

            // Loop method if console key tapped is empty
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) Example1_Main();
        }


        // Both threads run and print their message to the console.
        // Thread.Sleep(0) is used to signal to Windows that this thread is finished.
        // Instead of waiting for the whole time-slice of the thread to finish,
        // it will immediately switch to another thread.
    }
}
