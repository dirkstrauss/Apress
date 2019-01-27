using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleAppAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {


            var result = await GetSomething();

            ReadLine();
        }

        static async Task<int> GetSomething()
        {
            await Task.Delay(1000);
            return 0;
        }
    }
}
