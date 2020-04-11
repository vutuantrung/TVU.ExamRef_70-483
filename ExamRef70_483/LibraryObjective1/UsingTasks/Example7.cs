using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryObjective1.UsingTasks
{
    // Using Task.WaitAll
    public class Example7 : IExample
    {
        public void Main()
        {
            Task[] tasks = new Task[3];

            tasks[0] = Task.Run( () =>
            {
                Thread.Sleep( 1000 );
                Console.WriteLine( "1" );
                return 1;
            } );

            tasks[1] = Task.Run( () =>
            {
                Thread.Sleep( 1000 );
                Console.WriteLine( "2" );
                return 2;
            } );

            tasks[2] = Task.Run( () =>
            {
                Thread.Sleep( 1000 );
                Console.WriteLine( "3" );
                return 3;
            } );

            // This code will make process wait all task finish their job
            Task.WaitAll( tasks );
        }


        public void Example_Execute() => Main();
    }
}
