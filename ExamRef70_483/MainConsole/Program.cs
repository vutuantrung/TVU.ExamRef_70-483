using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryObjective1;

namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IExample example = new Example4();

            example.Example_Execute();
        }
    }
}
