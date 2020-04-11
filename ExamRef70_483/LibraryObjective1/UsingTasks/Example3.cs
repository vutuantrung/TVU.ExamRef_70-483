using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryObjective1.UsingTasks
{
    // Adding a continuation
    public class Example3 : IExample
    {
        public void Main()
        {
            Task<int> t = Task.Run( () =>
            {
                return 42;
            } ).ContinueWith( ( prevTask ) =>
            {
                return prevTask.Result * 2;
            } );

            Console.WriteLine( t.Result );
        }


        public void Example_Execute() => Main();

        // Add another operation when the previous one is finished
    }
}
