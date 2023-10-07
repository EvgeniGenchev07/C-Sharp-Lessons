using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            if (n < 1 || n > 105) throw new Exception("The number must be between 1 and 105");
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (input[0] < 1 || input[0] > 4) throw new Exception("The number must be between 1 and 4");
                if (input[0] == 1)
                {
                    if (input[1] < 1 || input[1] > 109) throw new Exception("The number must be between 1 and 109");
                    stack.Push(input[1]);
                }
                else if (input[0] == 2)
                {
                    stack.Pop();
                }
                else if (input[0] == 3)
                {
                    Console.WriteLine( stack.Max());
                }
                else if (input[0] == 4)
                {
                    Console.WriteLine( stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
