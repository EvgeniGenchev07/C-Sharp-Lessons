using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Loops
{
    internal class Program
    {
        
        static void SimulateNestedLoops(int n, int[] variables, int depth = 0)
        {
            if (depth == n)
            {
                // All loops have reached their maximum iterations, print values
                Console.WriteLine(string.Join(" ", variables));
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    variables[depth] = i; // Update the iteration variable at the current depth
                    SimulateNestedLoops(n, variables, depth + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] variables = new int[n];
            SimulateNestedLoops(n, variables);
        }
        
    }
}

