using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryObjective1.UnderstandThreads
{
    // Using background thread
    public class Example2 : IExample
    {
        private void ThreadMethod()
        {
            for ( int i = 0; i < 10; i++ )
            {
                Console.WriteLine( "ThreadProc: {0}", i );
                Thread.Sleep( 1000 );
            }
        }

        private void Main()
        {
            Thread t = new Thread( new ThreadStart( ThreadMethod ) );

            // If true, the application will exits immediatly
            // If false (creating a foreground thread), the application prints the ThreadProc message 10 times
            t.IsBackground = false;

            t.Start();
        }

        public void Example_Execute() => Main();
    }

    // _The Foreground threads can be used to keep an application alive as long as they are running,
    // when all foreground threads end does the common language runtime (CLR) shut down application.
    // _The background threads are then terminated.
    // _When all the foreground threads complete execution, the application will exit before the background threads return.
    // _After all the foreground threads have been stopped, or after the application exitsm the system stops all background threads.
}
