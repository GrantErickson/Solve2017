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
            var result = Solver.Solve("888");
            foreach (var kvp in result)
            {
                Console.WriteLine($"{ kvp.Key} = { kvp.Value }");
            }
            Console.WriteLine($"Total: {result.Count}");
            Console.ReadLine();
        }
    }




}
