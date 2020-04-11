using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryObjective1.UsingTasks
{
    // Scheduling different continuation tasks
    public class Example4 : IExample
    {
        public void Main()
        {
            Task<int> t = Task.Run( () =>
            {
                return 42;
            } );

            // The overload when the task is canceled.
            t.ContinueWith( ( prevTask ) =>
            {
                Console.WriteLine( "Canceled." );
            }, TaskContinuationOptions.OnlyOnCanceled );

            // The overload when an exeption happens
            t.ContinueWith( ( prevTask ) =>
            {
                Console.WriteLine( "Faulted." );
            }, TaskContinuationOptions.OnlyOnFaulted );

            // The overload when the task completes succesfully.
            var completedTask = t.ContinueWith( ( prevTask ) =>
            {
                Console.WriteLine( "Completed." );
            }, TaskContinuationOptions.OnlyOnRanToCompletion );

            completedTask.Wait();
        }


        public void Example_Execute() => Main();
    }
}
