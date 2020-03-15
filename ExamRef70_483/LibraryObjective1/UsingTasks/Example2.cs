using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryObjective1.UsingTasks
{
    // Using a Task that returns a value
    public class Example2 : IExample
    {
        public void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            // Attempting to read the Result property on a Task will force the thread that's trying to read the result to wait until the Task is finished before continuing.
            // As long as the task is not finished, it is impossible to give the result.
            // If the Task is not finished, this will block the current thread.
            // So, no need to call Wait in this case.
            Console.WriteLine(t.Result);
        }


        public void Example_Execute() => Main();
    }
}
