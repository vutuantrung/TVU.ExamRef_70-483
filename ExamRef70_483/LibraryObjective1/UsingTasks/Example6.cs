using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryObjective1.UsingTasks
{
    // Using a TaskFactory
    public class Example6 : IExample
    {
        public void Main()
        {
            Task<int[]> parent = Task.Run(() =>
            {
                var results = new int[3];

                TaskFactory tf = new TaskFactory(
                    TaskCreationOptions.AttachedToParent,
                    TaskContinuationOptions.ExecuteSynchronously);

                // Compare to the previous example, creating the child tasks
                // This proccess is easier
                tf.StartNew(() => { results[0] = 0; });
                tf.StartNew(() => { results[1] = 1; });
                tf.StartNew(() => { results[2] = 2; });

                return results;
            });

            var finalTask = parent.ContinueWith(parentTask =>
            {
                foreach (int i in parentTask.Result)
                {
                    Console.WriteLine(i);
                }
            });

            finalTask.Wait();
        }

        public void Example_Execute() => Main();
    }
}

// TaskFactory is created with a certain configuration
// and can then be used to created Task with that configuration.