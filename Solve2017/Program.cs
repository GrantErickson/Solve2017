using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = "2017";
            Console.WriteLine($"Finding ways to mathematically create numbers 1 through 100 with the numbers '{numbers}'.");
            var result = Solver.Solve("2017");
            foreach (var kvp in result)
            {
                Console.WriteLine($"{ kvp.Key} = { kvp.Value }");
            }
            Console.WriteLine($"Total: {result.Count}");
            Console.ReadLine();
        }
    }




}
