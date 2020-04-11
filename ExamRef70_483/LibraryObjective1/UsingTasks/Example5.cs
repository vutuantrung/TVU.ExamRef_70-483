using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryObjective1.UsingTasks
{
    // Attaching child task to a parent task
    public class Example5 : IExample
    {
        public void Main()
        {
            Task<int[]> parent = Task.Run( () =>
            {
                int[] results = new int[ 3 ];
                // First task
                new Task( () =>
                {
                    results[ 0 ] = 0;
                }, TaskCreationOptions.AttachedToParent ).Start();
                // Second task
                new Task( () =>
                {
                    results[ 1 ] = 1;
                }, TaskCreationOptions.AttachedToParent ).Start();

                // Third task
                new Task( () =>
                {
                    results[ 2 ] = 2;
                }, TaskCreationOptions.AttachedToParent ).Start();

                return results;
            } );

            var finalTask = parent.ContinueWith( ( parentTask ) =>
            {
                foreach ( int i in parentTask.Result )
                {
                    Console.WriteLine( i );
                }
            } );

            finalTask.Wait();
        }

        public void Example_Execute() => Main();

        // The finalTask run only after the parentTask finished, 
        // and the parent Task finishes when all three children are finished
        // You can use this to create quite complex Task hierarchies that will go through all the steps you specified
    }
}
