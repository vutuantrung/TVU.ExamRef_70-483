using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryObjective1.UsingParallelClass
{
    // Using Parallel.For and Parallel.Foreach
    public class Example1 : IExample
    {
        public void Main()
        {
            Parallel.For(0, 10, (i) =>
            {
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, (i) =>
            {
                Thread.Sleep(1000);
            });
        }

        public void Example_Execute()
        {
            throw new NotImplementedException();
        }
    }
}
