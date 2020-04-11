using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryObjective1;
using LibraryObjective1.ThreadPools;

namespace MainConsole
{
    class Program
    {
        static void Main( string[] args )
        {
            IExample example = new Example1();

            example.Example_Execute();
        }
    }
}
