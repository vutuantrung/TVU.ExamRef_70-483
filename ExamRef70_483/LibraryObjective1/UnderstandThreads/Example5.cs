using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryObjective1.UnderstandThreads
{
    // Using the ThreadStaticAttribute
    public class Example5 : IExample
    {
        // making this field ThreadStatic attribute, each thread gets its own copy of a field
        // this variable will be copied in each thread
        [ThreadStatic]
        private static int _field;

        private void Main()
        {
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();


            // Loop method if console key tapped is empty
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) Main();
        }

        public void Example_Execute() => Main();

        // A thread has its own call stack that stores all the methods that are executed.
        // Local variables are stored on the call stack and are private to the thread.
        // A thread can also have its own data that’s not a local variable.
        // By marking a field with the [ThreadStatic] attribute, each thread gets its own copy of a field
    }
}
