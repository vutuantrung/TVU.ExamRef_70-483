using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryObjective1.UsingParallelClass
{
    // Using Paralle.Break
    public class Example2 : IExample
    {
        public void Main()
        {
            var result = Parallel.For( 0, 1000, ( int i, ParallelLoopState loopState ) =>
            {
                if ( i == 500 )
                {
                    Console.WriteLine( $"Breaking loop at { loopState.LowestBreakIteration }." );
                    loopState.Break();
                }
            } );
        }

        public void Example_Execute() => Main();
    }

    // When breaking the parallel loop, the result variable has an IsCompleted value of false
    // and LowestBreakIteration of 500.
    // When you use the Stop method, the LowestBreakIteration is null
}
