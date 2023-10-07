using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4.Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (orders.Where(x => x < 0).Count() > 0 && food < 0)
            {
                throw new Exception();
            }
            for (int i = 0; i < orders.Length; i++)
            {
                queue.Enqueue(orders[i]);
            }
            int j = 0;
            while (queue.Count() > 0 && queue.Peek() < food)
            {
                food -= queue.Dequeue();
                j++;
            }
            if (j != 0) Console.WriteLine(orders.Take(j).Max());
            //else Console.WriteLine(0);
            if (queue.Count() > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(", ", queue)}");
            }
            else Console.WriteLine("Orders complete");
        }
    }
}
