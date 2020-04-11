using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryObjective1.UsingTasks
{
    // Start a new Task
    public class Example1 : IExample
    {
        public void Main()
        {
            Task t = Task.Run( () =>
            {
                for ( int i = 0; i < 100; i++ )
                {
                    Console.Write( '*' );
                }
            } );

            t.Wait();
        }

        public void Example_Execute() => Main();
    }

    // (1) The Task can tell you if the work is completed and if the operation returns a result, the Task gives you the result.

    // (2) By default, the Task scheduler uses threads frin the thread pool to execute the Task.

    // (3) Tasks can be used to make your application more responsive.
    // (4) Executing a Task on another thread makes sense only:
    //      + if you want to keep the user interface thread free for other work or
    //      + if you want to parallelize your work on to multiple processors.
}
