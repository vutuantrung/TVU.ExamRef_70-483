using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryObjective1.UnderstandThreads
{
    // Using ThreadLocal<T>
    public class Example6 : IExample
    {
        // This class allow us to declare a variable which is not shared between threads
        // and one of his capabilities that we can initialize each instance of the variable as the class the supplied factory method to create and/or initialized value to be returned.
        // Also, unlike ThreadStatic which is only works on static fields, ThreadLocal can be applied to static or instance variables.
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
        {
            // This is a very useful tool because by asking this class,
            // we can observe the current thread: its information, its state...
            return Thread.CurrentThread.ManagedThreadId;
        });

        public void Main()
        {
            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread A: {0}", i);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread B: {0}", i);
                }
            }).Start();

            Console.ReadKey();
        }

        public void Example_Execute() => Main();

        // When a thread is created, the runtime ensures that the initiating thread’s execution context is flowed to the new thread.
        // This way the new thread has the same privileges as the parent thread.
    }
}
