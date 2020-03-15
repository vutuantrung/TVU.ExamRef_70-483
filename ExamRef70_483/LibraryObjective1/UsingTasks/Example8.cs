using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryObjective1.UsingTasks
{
    // Using Task.WaitAny
    public class Example8 : IExample
    {
        public void Main()
        {
            Task<int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

            while (tasks.Length >0)
            {
                // start a new lancement and return the index of the completed task object in the task array
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];

                Console.WriteLine(completedTask.Result);

                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }
        }

        public void Example_Execute() => Main();
    }
}
