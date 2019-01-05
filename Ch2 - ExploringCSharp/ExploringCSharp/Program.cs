using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExploringCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass();
            WriteLine($"PropA before calculation {d.PropA}");
            WriteLine($"PropB before calculation {d.PropB}");
            WriteLine($"Perform calculation {d.PerformCalculationAB()}");
            WriteLine($"PropA after calculation {d.PropA}");
            WriteLine($"PropB after calculation {d.PropB}");
            ReadLine();
        }
    }
}

